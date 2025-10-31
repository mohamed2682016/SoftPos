using Microsoft.Extensions.Logging;
using MudBlazor;
using MudBlazor.Services;
using SoftPos.Data;
using SoftPos.Services;
using SoftPos.Utilities;


namespace SoftPos
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Logging.AddDebug(); // Enables debug-level logging
            builder.Logging.SetMinimumLevel(LogLevel.Debug); // Set log level to debug
            builder.Services.AddBlazorWebViewDeveloperTools(); // Adds Blazor developer tools
            builder.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            });
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<DatabaseContext>();
            builder.Services.AddSingleton<BarcodeService>();
            builder.Services.AddSingleton<BackupRestoreService>();
            builder.Services.AddSingleton<ExcelImportService>();
            builder.Services.AddSingleton<IPreferences>(Preferences.Default);
            builder.Services.AddSingleton<EmailService>();
            builder.Services.AddSingleton<NetworkService>();
            builder.Services.AddSingleton<UnitService>(sp =>
            new UnitService(sp.GetRequiredService<DatabaseContext>().GetConnection()));
            builder.Services.AddSingleton<BrandService>(sp =>
            new BrandService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<TaxService>(sp =>
            new TaxService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<WarehouseService>(sp =>
            new WarehouseService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<CategoryService>(sp =>
            new CategoryService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<CurrencyService>(sp =>
            new CurrencyService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<CompanyService>(sp =>
            new CompanyService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<InvoiceSettingService>(sp =>
            new InvoiceSettingService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<FinancialYearService>(sp =>
            new FinancialYearService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<AccountGroupService>(sp =>
            new AccountGroupService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<AccountLedgerService>(sp =>
            new AccountLedgerService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<PurchaseInvoiceService>(sp =>
            new PurchaseInvoiceService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<ProductService>(sp =>
            new ProductService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<PurchaseReturnService>(sp =>
            new PurchaseReturnService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<SalesInvoiceService>(sp =>
            new SalesInvoiceService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<SalesReturnService>(sp =>
            new SalesReturnService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<PaymentOutService>(sp =>
            new PaymentOutService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<PaymentInService>(sp =>
            new PaymentInService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<TilesQuotationService>(sp =>
            new TilesQuotationService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<GreniteService>(sp =>
            new GreniteService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<ReportService>(sp =>
            new ReportService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<ItemPartiesExportService>(sp =>
            new ItemPartiesExportService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<CouponService>(sp =>
            new CouponService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<SalesRegisterService>(sp =>
            new SalesRegisterService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<ExpiryNotificationService>(sp =>
            new ExpiryNotificationService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<ExpenseService>(sp =>
            new ExpenseService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<ExpenseCategoryService>(sp =>
            new ExpenseCategoryService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<WasteService>(sp =>
            new WasteService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<SeedDataService>(sp =>
            new SeedDataService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddSingleton<DataCleanupService>(sp =>
            new DataCleanupService(sp.GetRequiredService<DatabaseContext>().GetConnection()));

            builder.Services.AddScoped<IPrintingService, PrintingService>();

            builder.Services.AddSingleton<BarcodeNumberService>();
            builder.Services.AddSingleton<UserService>(sp =>
    new UserService(
        sp.GetRequiredService<DatabaseContext>().GetConnection(),
        sp.GetRequiredService<IPreferences>()
    )
);

            // خدمة التحديثات
            builder.Services.AddSingleton<UpdateService>();

            // Build the app
            return builder.Build();
        }
    }
}
