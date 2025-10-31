namespace SoftPos.Resources
{
    /// <summary>
    /// ملف الترجمة الشامل - Comprehensive Translation File
    /// يجمع كل الترجمات في مكان واحد لسهولة الاستخدام
    /// </summary>
    public static class AllTranslations
    {
        // ===== Common Translations - الترجمات الشائعة =====
        public static class Common
        {
            // Actions - الإجراءات
            public static string Add => "إضافة";
            public static string Edit => "تعديل";
            public static string Delete => "حذف";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Close => "إغلاق";
            public static string Submit => "إرسال";
            public static string Update => "تحديث";
            public static string Create => "إنشاء";
            public static string View => "عرض";
            public static string Print => "طباعة";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Download => "تحميل";
            public static string Upload => "رفع";
            public static string Refresh => "تحديث";
            public static string Clear => "مسح";
            public static string Reset => "إعادة تعيين";
            public static string Back => "رجوع";
            public static string Next => "التالي";
            public static string Previous => "السابق";
            public static string Confirm => "تأكيد";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";

            // Status - الحالة
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string Pending => "قيد الانتظار";
            public static string Approved => "موافق عليه";
            public static string Rejected => "مرفوض";
            public static string Completed => "مكتمل";
            public static string Cancelled => "ملغي";
            public static string Draft => "مسودة";

            // Common Fields - الحقول الشائعة
            public static string Name => "الاسم";
            public static string Description => "الوصف";
            public static string Code => "الكود";
            public static string Date => "التاريخ";
            public static string Time => "الوقت";
            public static string Amount => "المبلغ";
            public static string Quantity => "الكمية";
            public static string Price => "السعر";
            public static string Total => "الإجمالي";
            public static string Discount => "الخصم";
            public static string Tax => "الضريبة";
            public static string GrandTotal => "الإجمالي النهائي";
            public static string Notes => "ملاحظات";
            public static string Remarks => "ملاحظات";
            public static string Status => "الحالة";
            public static string Type => "النوع";
            public static string Category => "الفئة";
            public static string Phone => "الهاتف";
            public static string Mobile => "الجوال";
            public static string Address => "العنوان";
            public static string City => "المدينة";
            public static string Country => "الدولة";
            public static string ZipCode => "الرمز البريدي";

            // Messages - الرسائل
            public static string SuccessfullySaved => "تم الحفظ بنجاح";
            public static string SuccessfullyUpdated => "تم التحديث بنجاح";
            public static string SuccessfullyDeleted => "تم الحذف بنجاح";
            public static string ConfirmDelete => "هل أنت متأكد من الحذف؟";
            public static string NoDataFound => "لا توجد بيانات";
            public static string Loading => "جاري التحميل...";
            public static string PleaseWait => "الرجاء الانتظار...";
            public static string Error => "خطأ";
            public static string Success => "نجح";
            public static string Warning => "تحذير";
            public static string Info => "معلومات";
            public static string Required => "مطلوب";
            public static string InvalidData => "بيانات غير صحيحة";

            // Yes/No - نعم/لا
            public static string Yes => "نعم";
            public static string No => "لا";
            public static string OK => "موافق";
        }

        // ===== Dashboard - لوحة التحكم =====
        public static class Dashboard
        {
            public static string Title => "لوحة التحكم";
            public static string Welcome => "مرحباً";
            public static string Home => "الرئيسية";
            public static string Overview => "نظرة عامة";
            public static string Summary => "ملخص";
            public static string Statistics => "الإحصائيات";
            public static string Analytics => "التحليلات";
            public static string Reports => "التقارير";
            public static string QuickActions => "إجراءات سريعة";
            public static string RecentActivity => "النشاط الأخير";
            public static string Notifications => "الإشعارات";
            public static string Alerts => "التنبيهات";
            public static string Messages => "الرسائل";
            public static string Updates => "التحديثات";
            public static string News => "الأخبار";
            public static string Events => "الأحداث";
            public static string Tasks => "المهام";
            public static string Calendar => "التقويم";
            public static string Weather => "الطقس";
            public static string Time => "الوقت";
            public static string Clock => "الساعة";

            // Financial Overview - النظرة المالية
            public static string TotalSales => "إجمالي المبيعات";
            public static string TotalPurchases => "إجمالي المشتريات";
            public static string TotalRevenue => "إجمالي الإيرادات";
            public static string TotalExpenses => "إجمالي المصروفات";
            public static string NetProfit => "صافي الربح";
            public static string GrossProfit => "إجمالي الربح";
            public static string OperatingProfit => "ربح التشغيل";
            public static string NetIncome => "صافي الدخل";
            public static string CashFlow => "تدفق النقدية";
            public static string BankBalance => "رصيد البنك";
            public static string CashInHand => "النقد في اليد";
            public static string AccountsReceivable => "المستحقات";
            public static string AccountsPayable => "المدفوعات";
            public static string OutstandingAmount => "المبلغ المستحق";
            public static string PaidAmount => "المبلغ المدفوع";
            public static string PendingAmount => "المبلغ المعلق";
            public static string OverdueAmount => "المبلغ المتأخر";
        }

        // ===== POS - نقطة البيع =====
        public static class POS
        {
            public static string Title => "نقطة البيع";
            public static string ChooseCustomer => "اختر العميل";
            public static string ScanSearchProduct => "امسح/ابحث عن المنتج بالاسم أو الباركود";
            public static string NoResultsFound => "لا توجد نتائج";
            public static string AddNewCustomer => "إضافة عميل جديد";
            public static string AddNewProduct => "إضافة منتج جديد";
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
            public static string SelectCategory => "اختر الفئة";
            public static string SelectBrand => "اختر العلامة التجارية";
            public static string HoldBills => "فواتير معلقة";
            public static string OnHoldBills => "الفواتير المعلقة";
            public static string ClearCart => "مسح السلة [F2]";
            public static string Cash => "نقدي [F1]";
            public static string Card => "بطاقة [F2]";
            public static string UPI => "UPI [F3]";
            public static string CreditSales => "مبيعات آجلة";
            public static string RegisterDetails => "تفاصيل السجل";
            public static string RecentTransaction => "المعاملات الأخيرة";
            public static string PrintReceipt => "طباعة الإيصال";
            public static string InStock => "متوفر";
            public static string OutOfStock => "غير متوفر";
            public static string LowStock => "مخزون منخفض";
            public static string NegativeStockWarning => "يوجد مخزون سالب، هل تريد المتابعة؟";
            public static string AddAtLeastOneProduct => "أضف منتج واحد على الأقل";
            public static string SelectValidCustomer => "اختر عميل صحيح";
            public static string GrandTotalCannotBeZero => "الإجمالي النهائي لا يمكن أن يكون صفر";
            public static string ChooseWarehouse => "اختر مستودع";
            public static string ZeroQuantityTransaction => "لا يمكن إنشاء معاملة بكمية صفر";
            public static string TransactionCompleted => "تمت المعاملة بنجاح";
            public static string ProductAdded => "تم إضافة المنتج";
            public static string ProductUpdated => "تم تحديث المنتج";
            public static string ProductRemoved => "تم حذف المنتج";
            public static string InvalidProductOrUnit => "منتج أو وحدة غير صحيحة";
            public static string CannotContinueNegativeStock => "لا يمكن المتابعة بسبب المخزون السالب";
            public static string ErrorLoadingData => "خطأ في تحميل البيانات";
            public static string ErrorSavingData => "خطأ في حفظ البيانات";
        }

        // ===== Sales - المبيعات =====
        public static class Sales
        {
            public static string Title => "المبيعات";
            public static string SalesInvoice => "فاتورة المبيعات";
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
            public static string SalesRegister => "سجل المبيعات";
            public static string PaymentIn => "المقبوضات";
            public static string Coupon => "الكوبونات";
        }

        // ===== Purchase - المشتريات =====
        public static class Purchase
        {
            public static string Title => "المشتريات";
            public static string PurchaseInvoice => "فاتورة المشتريات";
            public static string Create => "إنشاء";
            public static string FromDate => "من تاريخ";
            public static string ToDate => "إلى تاريخ";
            public static string Supplier => "المورد";
            public static string Choose => "اختر";
            public static string Status => "الحالة";
            public static string All => "الكل";
            public static string Pending => "قيد الانتظار";
            public static string PartialPaid => "مدفوع جزئياً";
            public static string Paid => "مدفوع";
            public static string Search => "بحث";
            public static string Date => "التاريخ";
            public static string InvoiceNo => "رقم الفاتورة";
            public static string SupplierName => "اسم المورد";
            public static string Amount => "المبلغ";
            public static string BalanceDue => "الرصيد المستحق";
            public static string View => "عرض";
            public static string Edit => "تعديل";
            public static string GeneratePayment => "إنشاء دفعة";
            public static string PurchaseReturn => "مرتجع مشتريات";
            public static string Delete => "حذف";
            public static string ConfirmDelete => "هل أنت متأكد من حذف فاتورة المشتريات؟";
            public static string DeleteSuccess => "تم حذف فاتورة المشتريات بنجاح.";
            public static string DeleteWarning => "لا يمكن حذف فاتورة المشتريات لأنها قيد الاستخدام.";
            public static string PaymentOut => "المدفوعات";
        }

        // ===== Inventory - المخزون =====
        public static class Inventory
        {
            public static string Title => "المخزون";
            public static string Products => "المنتجات";
            public static string Categories => "الفئات";
            public static string Brands => "العلامات التجارية";
            public static string Units => "الوحدات";
            public static string Warehouses => "المستودعات";
            public static string Taxes => "الضرائب";
            public static string Create => "إنشاء";
            public static string Edit => "تعديل";
            public static string Delete => "حذف";
            public static string View => "عرض";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string ProductName => "اسم المنتج";
            public static string ProductCode => "كود المنتج";
            public static string Barcode => "الباركود";
            public static string SKU => "رمز التخزين";
            public static string Description => "الوصف";
            public static string Category => "الفئة";
            public static string Brand => "العلامة التجارية";
            public static string Unit => "الوحدة";
            public static string SalesRate => "سعر البيع";
            public static string PurchaseRate => "سعر الشراء";
            public static string CostPrice => "سعر التكلفة";
            public static string SellingPrice => "سعر البيع";
            public static string MRP => "السعر الأقصى للبيع";
            public static string Discount => "الخصم";
            public static string Tax => "الضريبة";
            public static string TaxRate => "معدل الضريبة";
            public static string HSNCode => "كود HSN";
            public static string Image => "الصورة";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string CurrentStock => "المخزون الحالي";
            public static string MinimumStock => "الحد الأدنى للمخزون";
            public static string MaximumStock => "الحد الأقصى للمخزون";
            public static string ReorderLevel => "مستوى إعادة الطلب";
            public static string StockValue => "قيمة المخزون";
            public static string InStock => "متوفر";
            public static string OutOfStock => "غير متوفر";
            public static string LowStock => "مخزون منخفض";
            public static string OverStock => "مخزون زائد";
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
            public static string DailySales => "مبيعات اليوم";
            public static string WeeklySales => "مبيعات الأسبوع";
            public static string MonthlySales => "مبيعات الشهر";
            public static string YearlySales => "مبيعات السنة";
            public static string SalesByCustomer => "المبيعات حسب العميل";
            public static string SalesByProduct => "المبيعات حسب المنتج";
            public static string SalesByCategory => "المبيعات حسب الفئة";
            public static string SalesByPaymentMethod => "المبيعات حسب طريقة الدفع";
            public static string TopSellingProducts => "أفضل المنتجات مبيعاً";
            public static string SalesTrend => "اتجاه المبيعات";
            public static string ProfitAnalysis => "تحليل الأرباح";
            public static string SalesSummary => "ملخص المبيعات";
            public static string SalesDetails => "تفاصيل المبيعات";
            public static string SalesComparison => "مقارنة المبيعات";
            public static string SalesForecast => "توقع المبيعات";
        }

        // ===== Authentication - المصادقة =====
        public static class Auth
        {
            public static string Login => "تسجيل الدخول";
            public static string Logout => "تسجيل الخروج";
            public static string Register => "التسجيل";
            public static string Profile => "الملف الشخصي";
            public static string Password => "كلمة المرور";
            public static string Email => "البريد الإلكتروني";
            public static string Phone => "رقم الهاتف";
            public static string Address => "العنوان";
            public static string FullName => "الاسم الكامل";
            public static string Username => "اسم المستخدم";
            public static string Role => "الدور";
            public static string Permissions => "الصلاحيات";
            public static string LastLogin => "آخر تسجيل دخول";
            public static string ChangePassword => "تغيير كلمة المرور";
            public static string NewPassword => "كلمة المرور الجديدة";
            public static string ConfirmPassword => "تأكيد كلمة المرور";
            public static string OldPassword => "كلمة المرور القديمة";
            public static string RememberMe => "تذكرني";
            public static string ForgotPassword => "نسيت كلمة المرور؟";
            public static string ResetPassword => "إعادة تعيين كلمة المرور";
            public static string EnterEmail => "أدخل البريد الإلكتروني";
            public static string EnterPassword => "أدخل كلمة المرور";
            public static string LoginFailed => "فشل تسجيل الدخول";
            public static string InvalidCredentials => "بيانات اعتماد غير صحيحة";
            public static string AccountLocked => "الحساب مقفل";
            public static string AccountDisabled => "الحساب معطل";
            public static string LoginSuccess => "تم تسجيل الدخول بنجاح";
            public static string WelcomeBack => "مرحباً بعودتك";
            public static string Loading => "جاري تسجيل الدخول...";
        }

        // ===== Utilities - الأدوات =====
        public static class Utilities
        {
            public static string Title => "الأدوات";
            public static string BarcodeGenerator => "مولد الباركود";
            public static string ImportItems => "استيراد الأصناف";
            public static string BackupRestore => "النسخ الاحتياطي";
            public static string DataExport => "تصدير البيانات";
            public static string DataImport => "استيراد البيانات";
            public static string SystemMaintenance => "صيانة النظام";
            public static string EmailService => "خدمة البريد الإلكتروني";
            public static string SMSService => "خدمة الرسائل النصية";
            public static string NotificationService => "خدمة الإشعارات";
            public static string GenerateBarcode => "إنشاء باركود";
            public static string BarcodeType => "نوع الباركود";
            public static string BarcodeData => "بيانات الباركود";
            public static string BarcodeSize => "حجم الباركود";
            public static string BarcodeWidth => "عرض الباركود";
            public static string BarcodeHeight => "ارتفاع الباركود";
            public static string BarcodeFormat => "تنسيق الباركود";
            public static string BarcodeImage => "صورة الباركود";
            public static string DownloadBarcode => "تحميل الباركود";
            public static string PrintBarcode => "طباعة الباركود";
            public static string SaveBarcode => "حفظ الباركود";
            public static string BarcodeGenerated => "تم إنشاء الباركود بنجاح";
            public static string BarcodeGenerationFailed => "فشل في إنشاء الباركود";
            public static string InvalidBarcodeData => "بيانات الباركود غير صحيحة";
        }

        // ===== Navigation - التنقل =====
        public static class Navigation
        {
            public static string Dashboard => "لوحة التحكم";
            public static string Parties => "الأطراف";
            public static string AccountGroup => "مجموعات الحسابات";
            public static string AccountLedger => "دفتر الحسابات";
            public static string Customer => "العملاء";
            public static string Supplier => "الموردين";
            public static string Items => "الأصناف";
            public static string Product => "المنتجات";
            public static string Category => "الفئات";
            public static string Unit => "الوحدات";
            public static string Brand => "العلامات التجارية";
            public static string Warehouse => "المخازن";
            public static string Sales => "المبيعات";
            public static string SalesInvoice => "فاتورة مبيعات";
            public static string POS => "نقطة البيع";
            public static string SalesRegister => "سجل المبيعات";
            public static string PaymentIn => "المقبوضات";
            public static string SalesReturn => "مرتجع مبيعات";
            public static string Coupon => "الكوبونات";
            public static string Purchase => "المشتريات";
            public static string PurchaseBill => "فاتورة مشتريات";
            public static string PaymentOut => "المدفوعات";
            public static string PurchaseReturn => "مرتجع مشتريات";
            public static string Reports => "التقارير";
            public static string Utilities => "الأدوات";
            public static string BarcodeGenerator => "مولد الباركود";
            public static string ImportItems => "استيراد الأصناف";
            public static string BackupRestore => "النسخ الاحتياطي";
            public static string Settings => "الإعدادات";
        }

        // ===== Date Filters - فلاتر التاريخ =====
        public static class DateFilters
        {
            public static string Today => "اليوم";
            public static string Yesterday => "أمس";
            public static string ThisWeek => "هذا الأسبوع";
            public static string LastWeek => "الأسبوع الماضي";
            public static string ThisMonth => "هذا الشهر";
            public static string LastMonth => "الشهر الماضي";
            public static string ThisQuarter => "هذا الربع";
            public static string LastQuarter => "الربع الماضي";
            public static string ThisYear => "هذا العام";
            public static string LastYear => "العام الماضي";
            public static string YearToDate => "من بداية السنة";
            public static string MonthToDate => "من بداية الشهر";
            public static string WeekToDate => "من بداية الأسبوع";
            public static string CustomRange => "نطاق مخصص";
            public static string FromDate => "من تاريخ";
            public static string ToDate => "إلى تاريخ";
            public static string DateRange => "نطاق التاريخ";
            public static string SelectDate => "اختر التاريخ";
            public static string SelectRange => "اختر النطاق";
            public static string ApplyFilter => "تطبيق الفلتر";
            public static string ClearFilter => "مسح الفلتر";
            public static string ResetFilter => "إعادة تعيين الفلتر";
        }

        // ===== Validation Messages - رسائل التحقق =====
        public static class Validation
        {
            public static string Required => "مطلوب";
            public static string InvalidEmail => "بريد إلكتروني غير صحيح";
            public static string InvalidPhone => "رقم هاتف غير صحيح";
            public static string MinLength => "الحد الأدنى للطول هو {0} أحرف";
            public static string MaxLength => "الحد الأقصى للطول هو {0} أحرف";
            public static string MustBePositive => "يجب أن يكون رقم موجب";
            public static string MustBeGreaterThanZero => "يجب أن يكون أكبر من صفر";
            public static string SelectCustomer => "اختر عميل صحيح";
            public static string SelectProduct => "اختر منتج صحيح";
            public static string ZeroQuantity => "لا يمكن إنشاء معاملة بكمية صفر";
            public static string ZeroGrandTotal => "الإجمالي النهائي لا يمكن أن يكون صفر";
            public static string ChooseWarehouse => "اختر مستودع";
            public static string AddAtLeastOneProduct => "أضف منتج واحد على الأقل";
            public static string CannotDeleteInUse => "لا يمكن الحذف لأن العنصر قيد الاستخدام";
            public static string RequiredField => "هذا الحقل مطلوب";
            public static string InvalidData => "بيانات غير صحيحة";
            public static string DuplicateCode => "الكود موجود مسبقاً";
            public static string DuplicateName => "الاسم موجود مسبقاً";
            public static string InvalidCredentials => "بيانات اعتماد غير صحيحة";
            public static string AccountLocked => "الحساب مقفل";
            public static string AccountDisabled => "الحساب معطل";
            public static string SessionExpired => "انتهت صلاحية الجلسة";
            public static string AccessDenied => "تم رفض الوصول";
            public static string PermissionDenied => "تم رفض الإذن";
        }

        // ===== Success Messages - رسائل النجاح =====
        public static class Success
        {
            public static string SavedSuccessfully => "تم الحفظ بنجاح";
            public static string UpdatedSuccessfully => "تم التحديث بنجاح";
            public static string DeletedSuccessfully => "تم الحذف بنجاح";
            public static string CreatedSuccessfully => "تم الإنشاء بنجاح";
            public static string PaymentProcessed => "تمت معالجة الدفعة بنجاح";
            public static string InvoiceGenerated => "تم إنشاء الفاتورة بنجاح";
            public static string DataLoaded => "تم تحميل البيانات بنجاح";
            public static string LoginSuccess => "تم تسجيل الدخول بنجاح";
            public static string LogoutSuccess => "تم تسجيل الخروج بنجاح";
            public static string RegistrationSuccess => "تم إنشاء الحساب بنجاح";
            public static string ProfileUpdated => "تم تحديث الملف الشخصي بنجاح";
            public static string PasswordChanged => "تم تغيير كلمة المرور بنجاح";
            public static string PasswordReset => "تم إعادة تعيين كلمة المرور بنجاح";
            public static string UserCreated => "تم إنشاء المستخدم بنجاح";
            public static string UserUpdated => "تم تحديث المستخدم بنجاح";
            public static string UserDeleted => "تم حذف المستخدم بنجاح";
            public static string RoleCreated => "تم إنشاء الدور بنجاح";
            public static string RoleUpdated => "تم تحديث الدور بنجاح";
            public static string RoleDeleted => "تم حذف الدور بنجاح";
            public static string PermissionCreated => "تم إنشاء الصلاحية بنجاح";
            public static string PermissionUpdated => "تم تحديث الصلاحية بنجاح";
            public static string PermissionDeleted => "تم حذف الصلاحية بنجاح";
            public static string VerificationSuccess => "تم التحقق بنجاح";
            public static string DataSaved => "تم حفظ البيانات بنجاح";
            public static string DataUpdated => "تم تحديث البيانات بنجاح";
            public static string DataDeleted => "تم حذف البيانات بنجاح";
        }

        // ===== Error Messages - رسائل الخطأ =====
        public static class Error
        {
            public static string ErrorOccurred => "حدث خطأ";
            public static string ErrorLoadingData => "خطأ في تحميل البيانات";
            public static string ErrorSavingData => "خطأ في حفظ البيانات";
            public static string ErrorDeletingData => "خطأ في حذف البيانات";
            public static string InvalidData => "بيانات غير صحيحة";
            public static string RequiredField => "هذا الحقل مطلوب";
            public static string SelectCustomer => "اختر عميل صحيح";
            public static string SelectProduct => "اختر منتج صحيح";
            public static string ZeroQuantity => "لا يمكن إنشاء معاملة بكمية صفر";
            public static string ZeroGrandTotal => "الإجمالي النهائي لا يمكن أن يكون صفر";
            public static string ChooseWarehouse => "اختر مستودع";
            public static string AddAtLeastOneProduct => "أضف منتج واحد على الأقل";
            public static string CannotDeleteInUse => "لا يمكن الحذف لأن العنصر قيد الاستخدام";
            public static string LoginFailed => "فشل تسجيل الدخول";
            public static string LogoutFailed => "فشل تسجيل الخروج";
            public static string RegistrationFailed => "فشل في إنشاء الحساب";
            public static string ProfileUpdateFailed => "فشل في تحديث الملف الشخصي";
            public static string PasswordChangeFailed => "فشل في تغيير كلمة المرور";
            public static string PasswordResetFailed => "فشل في إعادة تعيين كلمة المرور";
            public static string UserCreationFailed => "فشل في إنشاء المستخدم";
            public static string UserUpdateFailed => "فشل في تحديث المستخدم";
            public static string UserDeletionFailed => "فشل في حذف المستخدم";
            public static string RoleCreationFailed => "فشل في إنشاء الدور";
            public static string RoleUpdateFailed => "فشل في تحديث الدور";
            public static string RoleDeletionFailed => "فشل في حذف الدور";
            public static string PermissionCreationFailed => "فشل في إنشاء الصلاحية";
            public static string PermissionUpdateFailed => "فشل في تحديث الصلاحية";
            public static string PermissionDeletionFailed => "فشل في حذف الصلاحية";
            public static string VerificationFailed => "فشل في التحقق";
            public static string NetworkError => "خطأ في الشبكة";
            public static string ServerError => "خطأ في الخادم";
            public static string SessionExpired => "انتهت صلاحية الجلسة";
            public static string AccessDenied => "تم رفض الوصول";
            public static string PermissionDenied => "تم رفض الإذن";
        }

        // ===== Warning Messages - رسائل التحذير =====
        public static class Warning
        {
            public static string UnsavedChanges => "لديك تغييرات غير محفوظة";
            public static string LowStock => "المخزون منخفض";
            public static string OutOfStock => "المنتج غير متوفر";
            public static string DuplicateEntry => "هذا الإدخال موجود مسبقاً";
            public static string InvalidDate => "تاريخ غير صحيح";
            public static string InvalidAmount => "مبلغ غير صحيح";
            public static string NegativeStockWarning => "يوجد مخزون سالب، هل تريد المتابعة؟";
            public static string CannotDeleteInUse => "لا يمكن الحذف لأن العنصر قيد الاستخدام";
            public static string CannotContinueNegativeStock => "لا يمكن المتابعة بسبب المخزون السالب";
            public static string InvalidProductOrUnit => "منتج أو وحدة غير صحيحة";
            public static string InvalidCredentials => "بيانات اعتماد غير صحيحة";
            public static string AccountLocked => "الحساب مقفل";
            public static string AccountDisabled => "الحساب معطل";
            public static string SessionExpired => "انتهت صلاحية الجلسة";
            public static string AccessDenied => "تم رفض الوصول";
            public static string PermissionDenied => "تم رفض الإذن";
        }

        // ===== Confirmation Messages - رسائل التأكيد =====
        public static class Confirmation
        {
            public static string ConfirmDelete => "هل أنت متأكد من الحذف؟";
            public static string ConfirmCancel => "هل أنت متأكد من الإلغاء؟";
            public static string ConfirmSave => "هل تريد حفظ التغييرات؟";
            public static string ConfirmExit => "هل تريد الخروج؟";
            public static string ConfirmPayment => "هل تريد تأكيد الدفعة؟";
            public static string ConfirmLogout => "هل تريد تسجيل الخروج؟";
            public static string ConfirmReset => "هل تريد إعادة تعيين البيانات؟";
            public static string ConfirmClear => "هل تريد مسح البيانات؟";
            public static string ConfirmUpdate => "هل تريد تحديث البيانات؟";
            public static string ConfirmCreate => "هل تريد إنشاء العنصر؟";
        }

        // ===== Info Messages - رسائل معلوماتية =====
        public static class Info
        {
            public static string Loading => "جاري التحميل...";
            public static string PleaseWait => "الرجاء الانتظار...";
            public static string Processing => "جاري المعالجة...";
            public static string NoDataFound => "لا توجد بيانات";
            public static string NoRecordsFound => "لا توجد سجلات";
            public static string SelectOption => "اختر خيار";
            public static string DataSaved => "تم حفظ البيانات";
            public static string DataUpdated => "تم تحديث البيانات";
            public static string DataDeleted => "تم حذف البيانات";
            public static string DataLoaded => "تم تحميل البيانات";
            public static string DataRefreshed => "تم تحديث البيانات";
            public static string DataExported => "تم تصدير البيانات";
            public static string DataImported => "تم استيراد البيانات";
            public static string DataBackedUp => "تم إنشاء النسخ الاحتياطي";
            public static string DataRestored => "تم استعادة البيانات";
        }
    }
}

