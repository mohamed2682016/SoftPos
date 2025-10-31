using System.Diagnostics;
using System.Text.Json;

namespace SoftPos.Services
{
    public class UpdateService
    {
        // غير الرابط ده لرابط الـ repo بتاعك على GitHub
        private const string VERSION_URL = "https://raw.githubusercontent.com/mohamed2682016/SoftPos/main/version.json";
        private const string CURRENT_VERSION = "1.0.0";

        public async Task<UpdateInfo?> CheckForUpdates()
        {
            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "SoftPos");
                client.Timeout = TimeSpan.FromSeconds(10);

                var json = await client.GetStringAsync(VERSION_URL);
                var updateInfo = JsonSerializer.Deserialize<UpdateInfo>(json);

                if (updateInfo != null && IsNewerVersion(updateInfo.Version, CURRENT_VERSION))
                {
                    return updateInfo;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"خطأ في فحص التحديثات: {ex.Message}");
            }

            return null;
        }

        public string GetCurrentVersion()
        {
            return CURRENT_VERSION;
        }

        private bool IsNewerVersion(string serverVersion, string currentVersion)
        {
            try
            {
                var server = new Version(serverVersion);
                var current = new Version(currentVersion);
                return server > current;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DownloadUpdate(string downloadUrl, string savePath, IProgress<double>? progress = null)
        {
            try
            {
                using var client = new HttpClient();
                client.Timeout = TimeSpan.FromMinutes(10);
                
                using var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                var totalBytes = response.Content.Headers.ContentLength ?? 0;
                var downloadedBytes = 0L;

                using var contentStream = await response.Content.ReadAsStreamAsync();
                using var fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None);

                var buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                    downloadedBytes += bytesRead;

                    if (totalBytes > 0 && progress != null)
                    {
                        var percentage = (double)downloadedBytes / totalBytes * 100;
                        progress.Report(percentage);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"خطأ في تحميل التحديث: {ex.Message}");
                return false;
            }
        }

        public void OpenDownloadFolder(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Process.Start("explorer.exe", $"/select,\"{filePath}\"");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"خطأ في فتح المجلد: {ex.Message}");
            }
        }
    }

    public class UpdateInfo
    {
        public string Version { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public string DownloadUrl { get; set; } = string.Empty;
        public string FileSize { get; set; } = string.Empty;
        public string ReleaseNotes { get; set; } = string.Empty;
        public string ReleaseNotesAr { get; set; } = string.Empty;
        public bool Mandatory { get; set; }
        public string MinVersion { get; set; } = string.Empty;
    }
}
