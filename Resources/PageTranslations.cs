namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات صفحات التطبيق - Page Translations
    /// </summary>
    public static class PageTranslations
    {
        // ===== Auth Translations - ترجمات المصادقة =====
        public static class AuthTranslations
        {
            public static string Email => "البريد الإلكتروني";
            public static string EnterEmail => "أدخل البريد الإلكتروني";
            public static string Password => "كلمة المرور";
            public static string EnterPassword => "أدخل كلمة المرور";
            public static string RememberMe => "تذكرني";
            public static string Login => "تسجيل الدخول";
            public static string ForgotPassword => "نسيت كلمة المرور؟";
            public static string ResetNow => "إعادة تعيين الآن";
        }

        // ===== Navigation Translations - ترجمات القائمة =====
        public static class NavigationTranslations
        {
            public static string Dashboard => "لوحة التحكم";
            public static string Parties => "الأطراف";
            public static string AccountGroup => "مجموعة الحسابات";
            public static string AccountLedger => "دفتر الحسابات";
            public static string Customer => "العملاء";
            public static string Supplier => "الموردون";
            public static string Items => "الأصناف";
            public static string Product => "المنتجات";
            public static string Category => "الفئات";
            public static string Unit => "الوحدات";
            public static string Brand => "العلامات التجارية";
            public static string Warehouse => "المستودعات";
        }

        // ===== Dashboard Translations - ترجمات لوحة التحكم =====
        public static class DashboardTranslations
        {
            public static string Search => "بحث";
            public static string TotalReceivables => "إجمالي المستحقات";
            public static string FromParties => "من الأطراف";
            public static string TotalPayables => "إجمالي المدفوعات";
            public static string TotalSales => "إجمالي المبيعات";
        }

        // ===== POS Translations - ترجمات نقطة البيع =====
        public static class PosTranslations
        {
            public static string Total => "الإجمالي";
        }
        // ===== POS Page - صفحة نقطة البيع =====
        public static class POS
        {
            public static string Title => "نقطة البيع";
            public static string ChooseCustomer => "اختر العميل";
            public static string ScanSearchProduct => "امسح/ابحث عن المنتج بالاسم أو الباركود";
            public static string NoResultsFound => "لا توجد نتائج";
            public static string Item => "الصنف";
            public static string Qty => "الكمية";
            public static string Rate => "السعر";
            public static string DiscountPercent => "الخصم (%)";
            public static string Actions => "الإجراءات";
            public static string NoItemsInCart => "لا توجد أصناف في السلة";
            public static string Quantity => "الكمية";
            public static string TaxableAmount => "المبلغ الخاضع للضريبة";
            public static string TaxAmount => "قيمة الضريبة";
            public static string ApplyCoupon => "تطبيق كوبون";
            public static string FlatDiscount => "خصم ثابت";
            public static string TotalAmount => "المبلغ الإجمالي";
            public static string AllCategories => "كل الفئات";
            public static string AllBrands => "كل العلامات التجارية";
            public static string HoldBills => "فواتير معلقة";
            public static string OnHoldBills => "الفواتير المعلقة";
            public static string ClearCart => "مسح السلة [F2]";
            public static string Cash => "نقدي [F1]";
            public static string Card => "بطاقة [F2]";
            public static string UPI => "UPI [F3]";
            public static string RegisterDetails => "تفاصيل السجل";
            public static string RecentTransaction => "المعاملات الأخيرة";
        }

        // ===== Sales Invoice - فاتورة المبيعات =====
        public static class SalesInvoice
        {
            public static string Title => "فاتورة المبيعات";
            public static string Create => "إنشاء";
            public static string FromDate => "من تاريخ";
            public static string ToDate => "إلى تاريخ";
            public static string Customer => "العميل";
            public static string Choose => "اختر";
            public static string Status => "الحالة";
            public static string All => "الكل";
            public static string Pending => "قيد الانتظار";
            public static string PartialPaid => "مدفوع جزئياً";
            public static string Paid => "مدفوع";
            public static string Search => "بحث";
            public static string Date => "التاريخ";
            public static string InvoiceNo => "رقم الفاتورة";
            public static string CustomerName => "اسم العميل";
            public static string Amount => "المبلغ";
            public static string BalanceDue => "الرصيد المستحق";
            public static string View => "عرض";
            public static string Edit => "تعديل";
            public static string GeneratePayment => "إنشاء دفعة";
            public static string SalesReturn => "مرتجع مبيعات";
            public static string Delete => "حذف";
            public static string ConfirmDelete => "هل أنت متأكد من حذف فاتورة المبيعات؟";
            public static string DeleteSuccess => "تم حذف فاتورة المبيعات بنجاح.";
            public static string DeleteWarning => "لا يمكن حذف فاتورة المبيعات لأنها قيد الاستخدام.";
        }

        // ===== Product - المنتجات =====
        public static class Product
        {
            public static string Title => "المنتجات";
            public static string Create => "إنشاء";
            public static string ProductName => "اسم المنتج";
            public static string Code => "الكود";
            public static string Category => "الفئة";
            public static string Brand => "العلامة التجارية";
            public static string Unit => "الوحدة";
            public static string SalesRate => "سعر البيع";
            public static string PurchaseRate => "سعر الشراء";
            public static string Edit => "تعديل";
            public static string Delete => "حذف";
            public static string ConfirmDelete => "هل أنت متأكد من حذف هذا المنتج؟";
            public static string DeleteSuccess => "تم حذف المنتج بنجاح.";
            public static string DeleteError => "لا يمكن حذف المنتج لأنه قيد الاستخدام.";
        }

        // ===== Purchase - المشتريات =====
        public static class Purchase
        {
            public static string Title => "فاتورة المشتريات";
            public static string Create => "إنشاء";
            public static string Supplier => "المورد";
            public static string PurchaseNo => "رقم المشتريات";
            public static string SupplierName => "اسم المورد";
        }

        // ===== Payment - الدفعات =====
        public static class Payment
        {
            public static string PaymentIn => "دفعة واردة";
            public static string PaymentOut => "دفعة صادرة";
            public static string PaymentMethod => "طريقة الدفع";
            public static string PaymentDate => "تاريخ الدفع";
            public static string PaymentAmount => "مبلغ الدفعة";
            public static string Reference => "المرجع";
        }

        // ===== Reports - التقارير =====
        public static class Reports
        {
            public static string Title => "التقارير";
            public static string SalesReport => "تقرير المبيعات";
            public static string PurchaseReport => "تقرير المشتريات";
            public static string StockReport => "تقرير المخزون";
            public static string ProfitLossReport => "تقرير الأرباح والخسائر";
            public static string CustomerReport => "تقرير العملاء";
            public static string SupplierReport => "تقرير الموردين";
            public static string GenerateReport => "إنشاء تقرير";
        }

        // ===== Inventory Settings - إعدادات المخزون =====
        public static class InventorySettings
        {
            public static string Title => "إعدادات المخزون";
            public static string Products => "المنتجات";
            public static string Categories => "الفئات";
            public static string Brands => "العلامات التجارية";
            public static string Units => "الوحدات";
            public static string Warehouses => "المستودعات";
            public static string Taxes => "الضرائب";
        }

        // ===== Account Settings - إعدادات الحسابات =====
        public static class AccountSettings
        {
            public static string Title => "إعدادات الحسابات";
            public static string Customers => "العملاء";
            public static string Suppliers => "الموردون";
            public static string AccountLedger => "دفتر الحسابات";
        }

        // ===== User Management - إدارة المستخدمين =====
        public static class UserManagement
        {
            public static string Title => "إدارة المستخدمين";
            public static string Users => "المستخدمين";
            public static string Roles => "الأدوار";
            public static string Permissions => "الصلاحيات";
        }

        // ===== Company Settings - إعدادات الشركة =====
        public static class CompanySettings
        {
            public static string Title => "إعدادات الشركة";
            public static string CompanyInfo => "معلومات الشركة";
            public static string CompanyName => "اسم الشركة";
            public static string CompanyLogo => "شعار الشركة";
            public static string Address => "العنوان";
            public static string Phone => "الهاتف";
            public static string Email => "البريد الإلكتروني";
            public static string Website => "الموقع الإلكتروني";
            public static string Currency => "العملة";
            public static string TaxNumber => "الرقم الضريبي";
        }

        // ===== General Translations - ترجمات عامة =====
        public static string Company => "الشركة";
        public static string FinancialYear => "السنة المالية";
        public static string Tax => "الضريبة";
        public static string Currency => "العملة";
        public static string InvoiceSetting => "إعدادات الفاتورة";
        public static string Create => "إنشاء";
        public static string Edit => "تعديل";
        public static string Delete => "حذف";
        public static string Save => "حفظ";
        public static string Cancel => "إلغاء";
        public static string Action => "الإجراء";
        public static string Yes => "نعم";
        public static string No => "لا";
        
        // Company Page
        public static string CompanyName => "اسم الشركة";
        public static string Address => "العنوان";
        public static string MobileNo => "رقم الجوال";
        public static string Email => "البريد الإلكتروني";
        public static string Warehouse => "المستودع";
        public static string NumberOfDecimals => "عدد الخانات العشرية";
        public static string Website => "الموقع الإلكتروني";
        public static string GSTNumber => "رقم GST";
        public static string PANNumber => "رقم PAN";
        public static string LUTNumber => "رقم LUT";
        public static string IECNumber => "رقم IEC";
        public static string Logo => "الشعار";
        public static string IsDefault => "افتراضي";
        public static string SaveCompany => "حفظ الشركة";
        
        // Coupon Page
        public static string Coupon => "الكوبون";
        public static string Code => "الكود";
        public static string IsPercentage => "نسبة مئوية";
        public static string Amount => "المبلغ";
        public static string ExpiryDate => "تاريخ الانتهاء";
        public static string ExpiredDate => "تاريخ الانتهاء";
        public static string CreateCoupon => "إنشاء كوبون";
        public static string EditCoupon => "تعديل كوبون";
        public static string EnterCouponName => "أدخل اسم الكوبون";
        
        // Currency Page
        public static string CurrencyName => "اسم العملة";
        public static string Symbol => "الرمز";
        public static string CurrencySymbol => "رمز العملة";
        public static string CreateCurrency => "إنشاء عملة";
        public static string EditCurrency => "تعديل عملة";
        public static string EnterCurrencyName => "أدخل اسم العملة";
        public static string EnterCurrencySymbol => "أدخل رمز العملة";
        
        // Financial Year Page
        public static string FromDate => "من تاريخ";
        public static string ToDate => "إلى تاريخ";
        public static string FiscalYear => "السنة المالية";
        public static string CreateFinancialYear => "إنشاء سنة مالية";
        public static string EditFinancialYear => "تعديل سنة مالية";
        public static string ChangeFiscalYear => "تغيير السنة المالية";
        public static string EnterFiscalYear => "أدخل السنة المالية";
        
        // Invoice Setting Page
        public static string VoucherType => "نوع السند";
        public static string Prefix => "البادئة";
        public static string Suffix => "اللاحقة";
        public static string StartIndex => "الفهرس الابتدائي";
        public static string CreateInvoiceSetting => "إنشاء إعدادات الفاتورة";
        public static string EditInvoiceSetting => "تعديل إعدادات الفاتورة";
        public static string EnterVoucherTypeName => "أدخل اسم نوع السند";
        public static string EnterPrefix => "أدخل البادئة";
        public static string EnterSuffix => "أدخل اللاحقة";

        // ===== Sales Register - سجل المبيعات =====
        public static class SalesRegister
        {
            public static string Title => "سجل المبيعات";
            public static string CashRegisterDetails => "تفاصيل سجل النقدية";
            public static string FromDate => "من تاريخ";
            public static string ToDate => "إلى تاريخ";
            public static string Cashier => "أمين الصندوق";
            public static string AllUsers => "جميع المستخدمين";
            public static string Search => "بحث";
            public static string Status => "الحالة";
            public static string CashInHand => "النقد في اليد";
            public static string Cash => "نقد";
            public static string Card => "بطاقة";
            public static string UPI => "UPI";
            public static string PayLater => "دفع لاحق";
            public static string TotalSales => "إجمالي المبيعات";
            public static string CreditAppliedAmount => "مبلغ الائتمان المطبق";
            public static string SalesReturnAmount => "مبلغ مرتجعات المبيعات";
            public static string ClosingAmount => "مبلغ الإغلاق";
            public static string Total => "الإجمالي";
            public static string NoData => "لا توجد بيانات";
            public static string NoRecordsFound => "لا توجد سجلات مبيعات في النطاق الزمني المحدد";
            public static string Open => "مفتوح";
            public static string Closed => "مغلق";
            public static string Unknown => "غير محدد";
            
            // Sales Register Popup
            public static string Category => "الفئة";
            public static string Amount => "المبلغ";
            public static string OpeningCash => "النقد الافتتاحي";
            public static string SalesReturn => "مرتجعات المبيعات";
            public static string CashReturn => "مرتجعات نقدية";
            public static string CreditApplied => "مبلغ الائتمان المطبق";
            public static string Expense => "المصروفات";
            public static string PurchasePayment => "مدفوعات المشتريات";
            public static string TotalCashLeftInDrawer => "إجمالي النقد المتبقي في الدرج";
            public static string PhysicalDrawer => "الدرج الفعلي";
            public static string Short => "النقص";
            public static string ClosingNote => "ملاحظة الإغلاق";
            public static string CloseRegister => "إغلاق السجل";
            public static string Close => "إغلاق";
            public static string To => "إلى";
            public static string EnterClosingNote => "أدخل ملاحظة الإغلاق...";
            
            // Payment Methods
            public static string CashPayment => "النقد";
            public static string CardPayment => "البطاقة";
            public static string UPIPayment => "UPI";
            public static string CreditPayment => "الائتمان";
            
            // Messages
            public static string UserNotFound => "خطأ: لم يتم العثور على المستخدم الحالي";
            public static string NoOpenRegister => "تحذير: لا يوجد سجل مفتوح للمستخدم الحالي";
            public static string NegativeAmountError => "خطأ: لا يمكن أن يكون المبلغ الفعلي في الدرج سالباً";
            public static string RegisterClosedSuccess => "تم إغلاق السجل بنجاح";
            public static string RegisterCloseFailed => "فشل في إغلاق السجل";
            public static string DataLoadError => "خطأ في تحميل البيانات";
            public static string UnexpectedError => "خطأ غير متوقع";
        }
    }
}
