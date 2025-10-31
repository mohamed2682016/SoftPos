using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace SoftPos.Services;

/// <summary>
/// خدمة الترخيص - ربط البرنامج بجهاز معين
/// </summary>
public class LicenseService
{
    private const string LICENSE_FILE = "license.key";
    private const string SECRET_KEY = "SoftPos2025SecretKey!@#"; // غيّر هذا المفتاح لمفتاح خاص بك

    /// <summary>
    /// الحصول على معرف فريد للجهاز (Hardware ID)
    /// </summary>
    public static string GetHardwareId()
    {
        try
        {
            var hardwareInfo = new StringBuilder();

            // 1. معرف اللوحة الأم
            hardwareInfo.Append(GetMotherboardId());
            hardwareInfo.Append("|");

            // 2. معرف المعالج
            hardwareInfo.Append(GetProcessorId());
            hardwareInfo.Append("|");

            // 3. معرف القرص الصلب
            hardwareInfo.Append(GetDiskId());

            // تشفير المعلومات
            return ComputeHash(hardwareInfo.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting hardware ID: {ex.Message}");
            return "DEMO-MODE";
        }
    }

    private static string GetMotherboardId()
    {
        try
        {
            var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["SerialNumber"]?.ToString() ?? "";
            }
        }
        catch { }
        return "";
    }

    private static string GetProcessorId()
    {
        try
        {
            var searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["ProcessorId"]?.ToString() ?? "";
            }
        }
        catch { }
        return "";
    }

    private static string GetDiskId()
    {
        try
        {
            var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_DiskDrive");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["SerialNumber"]?.ToString() ?? "";
            }
        }
        catch { }
        return "";
    }

    private static string ComputeHash(string input)
    {
        using (var sha256 = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(input + SECRET_KEY);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }

    /// <summary>
    /// إنشاء ملف الترخيص للجهاز الحالي
    /// </summary>
    public static bool GenerateLicense()
    {
        try
        {
            var hardwareId = GetHardwareId();
            var licenseData = $"{hardwareId}|{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}";
            var encryptedLicense = EncryptString(licenseData);

            var licensePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LICENSE_FILE);
            File.WriteAllText(licensePath, encryptedLicense);

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating license: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// التحقق من صحة الترخيص
    /// </summary>
    public static bool ValidateLicense()
    {
        try
        {
            var licensePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LICENSE_FILE);

            if (!File.Exists(licensePath))
            {
                return false;
            }

            var encryptedLicense = File.ReadAllText(licensePath);
            var licenseData = DecryptString(encryptedLicense);

            if (string.IsNullOrEmpty(licenseData))
            {
                return false;
            }

            var parts = licenseData.Split('|');
            if (parts.Length < 2)
            {
                return false;
            }

            var storedHardwareId = parts[0];
            var currentHardwareId = GetHardwareId();

            return storedHardwareId == currentHardwareId;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error validating license: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// الحصول على معلومات الترخيص
    /// </summary>
    public static (bool IsValid, string HardwareId, DateTime? ActivationDate) GetLicenseInfo()
    {
        try
        {
            var licensePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LICENSE_FILE);

            if (!File.Exists(licensePath))
            {
                return (false, GetHardwareId(), null);
            }

            var encryptedLicense = File.ReadAllText(licensePath);
            var licenseData = DecryptString(encryptedLicense);

            if (string.IsNullOrEmpty(licenseData))
            {
                return (false, GetHardwareId(), null);
            }

            var parts = licenseData.Split('|');
            if (parts.Length < 2)
            {
                return (false, GetHardwareId(), null);
            }

            var hardwareId = parts[0];
            var activationDate = DateTime.Parse(parts[1]);
            var isValid = hardwareId == GetHardwareId();

            return (isValid, hardwareId, activationDate);
        }
        catch
        {
            return (false, GetHardwareId(), null);
        }
    }

    private static string EncryptString(string plainText)
    {
        try
        {
            using (var aes = Aes.Create())
            {
                var key = Encoding.UTF8.GetBytes(SECRET_KEY.PadRight(32).Substring(0, 32));
                aes.Key = key;
                aes.GenerateIV();

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
        catch
        {
            return string.Empty;
        }
    }

    private static string DecryptString(string cipherText)
    {
        try
        {
            var buffer = Convert.FromBase64String(cipherText);

            using (var aes = Aes.Create())
            {
                var key = Encoding.UTF8.GetBytes(SECRET_KEY.PadRight(32).Substring(0, 32));
                aes.Key = key;

                var iv = new byte[aes.IV.Length];
                Array.Copy(buffer, 0, iv, 0, iv.Length);
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(buffer, iv.Length, buffer.Length - iv.Length))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
        catch
        {
            return string.Empty;
        }
    }

    public static bool DeleteLicense()
    {
        try
        {
            var licensePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LICENSE_FILE);
            if (File.Exists(licensePath))
            {
                File.Delete(licensePath);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
}
