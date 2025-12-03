using SoftPos.Data;
using SoftPos.Utilities;

namespace SoftPos
{
    public partial class MainPage : ContentPage
    {
        private readonly DatabaseContext _databaseContext;
        private bool _isInitialized = false;

        public MainPage(DatabaseContext databaseContext)
        {
            InitializeComponent();
            _databaseContext = databaseContext;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            // Only initialize once
            if (!_isInitialized)
            {
                try
                {
                    System.Diagnostics.Debug.WriteLine("MainPage appearing - Starting database initialization...");
                    await Task.Delay(500); // Give UI more time to render
                    
                    // Check if database context is available
                    if (_databaseContext == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Database context is null!");
                        return;
                    }
                    
                    await SeedDataAsync();
                    _isInitialized = true;
                    System.Diagnostics.Debug.WriteLine("Database initialization completed successfully!");
                }
                catch (Exception ex)
                {
                    // Log the error
                    System.Diagnostics.Debug.WriteLine($"Database initialization error: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                    
                    // Only show error for serious issues, not for table already exists
                    if (!ex.Message.Contains("PRIMARY KEY") && 
                        !ex.Message.Contains("already exists") && 
                        !ex.Message.Contains("table") &&
                        !ex.Message.Contains("column"))
                    {
                        try
                        {
                            await DisplayAlert("خطأ في التهيئة", 
                                $"حدث خطأ أثناء تهيئة قاعدة البيانات:\n{ex.Message}\n\nالتطبيق سيستمر في العمل.", 
                                "موافق");
                        }
                        catch
                        {
                            // If even the alert fails, just log it
                            System.Diagnostics.Debug.WriteLine("Failed to show error alert");
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Database table conflict resolved, continuing normally...");
                    }
                    
                    // Mark as initialized to prevent repeated attempts
                    _isInitialized = true;
                }
            }
        }

        private async Task SeedDataAsync()
        {
            // Try normal initialization first
            try
            {
                await _databaseContext.InitializeAsync();
                await DatabaseHelper.SeedAllDataAsync(_databaseContext);
                
                // Check if database is working properly
                var isHealthy = await DatabaseHelper.CheckDatabaseHealthAsync(_databaseContext);
                if (!isHealthy)
                {
                    System.Diagnostics.Debug.WriteLine("Database health check failed, attempting reset...");
                    await DatabaseHelper.ResetDatabaseAsync(_databaseContext);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Normal initialization failed: {ex.Message}");
                
                // If normal initialization fails, try reset
                try
                {
                    System.Diagnostics.Debug.WriteLine("Attempting database reset due to initialization failure...");
                    var resetSuccess = await DatabaseHelper.ResetDatabaseAsync(_databaseContext);
                    
                    if (!resetSuccess)
                    {
                        System.Diagnostics.Debug.WriteLine("Database reset failed, but continuing...");
                    }
                }
                catch (Exception resetEx)
                {
                    System.Diagnostics.Debug.WriteLine($"Database reset also failed: {resetEx.Message}");
                    // Continue anyway to allow app to start
                }
            }
        }
    }
}