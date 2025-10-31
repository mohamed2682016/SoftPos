using Microsoft.JSInterop;

namespace SoftPos.Utilities
{
    public class PrintingService : IPrintingService
    {
        private IJSObjectReference module;
        private readonly IJSRuntime jsRuntime;

        public PrintingService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task Print(PrintOptions options)
        {
            try
            {
                if (module is null)
                    await ImportModule();

                if (module != null)
                {
                    await module.InvokeVoidAsync("print", new PrintOptionsAdapter(options));
                }
                else
                {
                    // Fallback: use global printJS function
                    var adapter = new PrintOptionsAdapter(options);
                    await jsRuntime.InvokeVoidAsync("printJS", new
                    {
                        printable = adapter.Printable,
                        type = adapter.Type,
                        showModal = adapter.ShowModal,
                        modalMessage = adapter.ModalMessage,
                        base64 = adapter.Base64,
                        targetStyles = new[] { "*" },
                        scanStyles = true
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Print method: {ex.Message}");
                // Final fallback: try browser print
                try
                {
                    if (options.Type == PrintType.Html)
                    {
                        await jsRuntime.InvokeVoidAsync("printDiv", options.Printable);
                    }
                    else
                    {
                        await jsRuntime.InvokeVoidAsync("window.print");
                    }
                }
                catch (Exception fallbackEx)
                {
                    Console.WriteLine($"Fallback print also failed: {fallbackEx.Message}");
                    throw new InvalidOperationException($"Print failed: {ex.Message}", ex);
                }
            }
        }

        public Task Print(string printable, PrintType printType = PrintType.Pdf)
        {
            return Print(new PrintOptions(printable) { Printable = printable, Type = printType });
        }
        public Task Print(string printable, bool showModal, PrintType printType = PrintType.Pdf)
        {
            return Print(new PrintOptions(printable) { ShowModal= showModal, Type = printType });
        }

        internal async ValueTask ImportModule()
        {
            try
            {
                module = await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./js/scripts.js");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing scripts.js: {ex.Message}");
                // Fallback: try to use global functions
                module = null;
            }
        }
    }
}
