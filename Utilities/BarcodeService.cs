using ZXing;
using ZXing.Common;

namespace SoftPos.Utilities
{
    public class BarcodeService
    {
        public static string GenerateBarcode(string input)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("BarcodeService: Input is null or empty");
                    return string.Empty;
                }

                // Clean the input - remove any non-printable characters
                input = input.Trim();

                var writer = new BarcodeWriterPixelData
                {
                    Format = BarcodeFormat.CODE_128, // You can change to QR_CODE, CODE_39, etc.
                    Options = new EncodingOptions
                    {
                        Height = 100, // Set height of the barcode
                        Width = 300,  // Set width of the barcode
                        Margin = 10
                    }
                };

                var pixelData = writer.Write(input);

                if (pixelData == null)
                {
                    Console.WriteLine($"BarcodeService: Failed to generate pixel data for input: {input}");
                    return string.Empty;
                }

                // Convert the PixelData to a PNG base64 string
                using var bitmap = new SkiaSharp.SKBitmap(pixelData.Width, pixelData.Height);
                var pixels = pixelData.Pixels;
                var index = 0;

                for (int y = 0; y < pixelData.Height; y++)
                {
                    for (int x = 0; x < pixelData.Width; x++)
                    {
                        var color = new SkiaSharp.SKColor(
                            pixels[index],
                            pixels[index + 1],
                            pixels[index + 2],
                            pixels[index + 3]);

                        bitmap.SetPixel(x, y, color);
                        index += 4;
                    }
                }

                using var image = SkiaSharp.SKImage.FromBitmap(bitmap);
                using var data = image.Encode(SkiaSharp.SKEncodedImageFormat.Png, 100);
                
                if (data == null)
                {
                    Console.WriteLine($"BarcodeService: Failed to encode image for input: {input}");
                    return string.Empty;
                }

                var result = Convert.ToBase64String(data.ToArray());
                Console.WriteLine($"BarcodeService: Successfully generated barcode for input: {input}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"BarcodeService: Error generating barcode for input '{input}': {ex.Message}");
                return string.Empty;
            }
        }
    }
}