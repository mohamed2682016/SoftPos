using SoftPos.Data;

namespace SoftPos
{
    public partial class App : Application
    {
        private readonly DatabaseContext _databaseContext;

        public App(DatabaseContext databaseContext)
        {
            try
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("🚀 بدء تشغيل تطبيق SoftPos");
                Console.WriteLine("===========================================");
                Console.WriteLine("💡 رسائل التشخيص ستظهر في هذه النافذة");
                Console.WriteLine("⚠️  لا تغلق هذه النافذة أثناء تشغيل التطبيق");
                Console.WriteLine("===========================================");
                
                System.Diagnostics.Debug.WriteLine("Starting App initialization...");
                
                InitializeComponent();
                System.Diagnostics.Debug.WriteLine("InitializeComponent completed");
                
                _databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
                System.Diagnostics.Debug.WriteLine("DatabaseContext assigned");
                
                // Use MainPage with database context
                MainPage = new MainPage(databaseContext);
                System.Diagnostics.Debug.WriteLine("MainPage created");
                
                Console.WriteLine("✅ تم تشغيل التطبيق بنجاح!");
                Console.WriteLine("📋 يمكنك الآن استخدام التطبيق");
                Console.WriteLine("===========================================");
                System.Diagnostics.Debug.WriteLine("App initialized successfully!");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"App initialization error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Exception type: {ex.GetType().FullName}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                    System.Diagnostics.Debug.WriteLine($"Inner stack trace: {ex.InnerException.StackTrace}");
                }
                
                // Create a simple error page instead of crashing
                try
                {
                    MainPage = new ContentPage
                    {
                        Content = new Label
                        {
                            Text = $"خطأ في تشغيل التطبيق:\n{ex.Message}\n\nيرجى إعادة تشغيل التطبيق.",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Center,
                            TextColor = Colors.Red
                        }
                    };
                }
                catch
                {
                    // If even creating error page fails, just throw
                    throw;
                }
            }
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Creating window...");
                var window = new Window(MainPage) 
                { 
                    Title = "SoftPos - نظام نقاط البيع",
                    Width = 1200,
                    Height = 800,
                    MinimumWidth = 800,
                    MinimumHeight = 600
                };
                
                System.Diagnostics.Debug.WriteLine("Window created successfully!");
                return window;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Window creation error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }
    }
}
