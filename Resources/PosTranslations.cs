namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات صفحة نقطة البيع - POS Page Translations
    /// </summary>
    public static class PosTranslations
    {
        // ===== Header Section - قسم الرأس =====
        public static string ChooseCustomer => "اختر العميل";
        public static string ScanSearchProduct => "امسح/ابحث عن المنتج بالاسم أو الباركود";
        public static string NoResultsFound => "لا توجد نتائج";
        public static string AddNewCustomer => "إضافة عميل جديد";
        public static string AddNewProduct => "إضافة منتج جديد";

        // ===== Cart Table Headers - رؤوس جدول السلة =====
        public static string Item => "الصنف";
        public static string Qty => "الكمية";
        public static string Rate => "السعر";
        public static string DiscountPercent => "الخصم (%)";
        public static string Actions => "الإجراءات";
        public static string NoItemsInCart => "لا توجد أصناف في السلة";
        public static string Quantity => "الكمية";

        // ===== Summary Section - قسم الملخص =====
        public static string TaxableAmount => "المبلغ الخاضع للضريبة";
        public static string TaxAmount => "قيمة الضريبة";
        public static string ApplyCoupon => "تطبيق كوبون";
        public static string FlatDiscount => "خصم ثابت";
        public static string TotalAmount => "المبلغ الإجمالي";

        // ===== Product Categories - فئات المنتجات =====
        public static string AllCategories => "كل الفئات";
        public static string AllBrands => "كل العلامات التجارية";
        public static string SelectCategory => "اختر الفئة";
        public static string SelectBrand => "اختر العلامة التجارية";

        // ===== Hold Bills - الفواتير المعلقة =====
        public static string HoldBills => "فواتير معلقة";
        public static string OnHoldBills => "الفواتير المعلقة";
        public static string ClearCart => "مسح السلة [F2]";

        // ===== Payment Methods - طرق الدفع =====
        public static string Cash => "نقدي [F1]";
        public static string Card => "بطاقة [F2]";
        public static string UPI => "UPI [F3]";
        public static string CreditSales => "مبيعات آجلة";

        // ===== Additional Features - الميزات الإضافية =====
        public static string RegisterDetails => "تفاصيل السجل";
        public static string RecentTransaction => "المعاملات الأخيرة";
        public static string PrintReceipt => "طباعة الإيصال";

        // ===== Stock Messages - رسائل المخزون =====
        public static string InStock => "متوفر";
        public static string OutOfStock => "غير متوفر";
        public static string LowStock => "مخزون منخفض";
        public static string NegativeStockWarning => "يوجد مخزون سالب، هل تريد المتابعة؟";

        // ===== Validation Messages - رسائل التحقق =====
        public static string AddAtLeastOneProduct => "أضف منتج واحد على الأقل";
        public static string SelectValidCustomer => "اختر عميل صحيح";
        public static string GrandTotalCannotBeZero => "الإجمالي النهائي لا يمكن أن يكون صفر";
        public static string ChooseWarehouse => "اختر مستودع";
        public static string ZeroQuantityTransaction => "لا يمكن إنشاء معاملة بكمية صفر";

        // ===== Success Messages - رسائل النجاح =====
        public static string TransactionCompleted => "تمت المعاملة بنجاح";
        public static string ProductAdded => "تم إضافة المنتج";
        public static string ProductUpdated => "تم تحديث المنتج";
        public static string ProductRemoved => "تم حذف المنتج";

        // ===== Error Messages - رسائل الخطأ =====
        public static string InvalidProductOrUnit => "منتج أو وحدة غير صحيحة";
        public static string CannotContinueNegativeStock => "لا يمكن المتابعة بسبب المخزون السالب";
        public static string ErrorLoadingData => "خطأ في تحميل البيانات";
        public static string ErrorSavingData => "خطأ في حفظ البيانات";

        // ===== Coupon Section - قسم الكوبونات =====
        public static string CouponCode => "كود الكوبون";
        public static string CouponAmount => "مبلغ الكوبون";
        public static string ApplyCouponCode => "تطبيق كود الكوبون";
        public static string RemoveCoupon => "إزالة الكوبون";

        // ===== Cash Register - الصندوق =====
        public static string OpeningCash => "النقد الافتتاحي";
        public static string ClosingCash => "النقد الختامي";
        public static string CashInHand => "النقد في اليد";
        public static string RegisterStatus => "حالة السجل";
        public static string Open => "مفتوح";
        public static string Closed => "مغلق";

        // ===== Recent Transactions - المعاملات الأخيرة =====
        public static string TransactionDate => "تاريخ المعاملة";
        public static string TransactionAmount => "مبلغ المعاملة";
        public static string TransactionType => "نوع المعاملة";
        public static string LoadTransaction => "تحميل المعاملة";

        // ===== Print Options - خيارات الطباعة =====
        public static string PrintBill => "طباعة الفاتورة";
        public static string EmailReceipt => "إرسال الإيصال بالبريد";
        public static string SMSReceipt => "إرسال الإيصال بالرسائل";

        // ===== Keyboard Shortcuts - اختصارات لوحة المفاتيح =====
        public static string F1Cash => "F1 - نقدي";
        public static string F2Card => "F2 - بطاقة";
        public static string F3UPI => "F3 - UPI";
        public static string F2ClearCart => "F2 - مسح السلة";
        public static string F4HoldBill => "F4 - تعليق الفاتورة";

        // ===== Product Search - البحث عن المنتجات =====
        public static string SearchByBarcode => "البحث بالباركود";
        public static string SearchByName => "البحث بالاسم";
        public static string ProductCode => "كود المنتج";
        public static string ProductName => "اسم المنتج";
        public static string CurrentStock => "المخزون الحالي";
        public static string SalesRate => "سعر البيع";
        public static string PurchaseRate => "سعر الشراء";

        // ===== Customer Information - معلومات العميل =====
        public static string CustomerName => "اسم العميل";
        public static string CustomerPhone => "هاتف العميل";
        public static string CustomerEmail => "بريد العميل";
        public static string CustomerAddress => "عنوان العميل";
        public static string CustomerBalance => "رصيد العميل";

        // ===== Discount Options - خيارات الخصم =====
        public static string PercentageDiscount => "خصم نسبة مئوية";
        public static string FixedDiscount => "خصم ثابت";
        public static string TotalDiscount => "إجمالي الخصم";
        public static string ApplyDiscount => "تطبيق الخصم";

        // ===== Tax Information - معلومات الضريبة =====
        public static string TaxRate => "معدل الضريبة";
        public static string TaxName => "اسم الضريبة";
        public static string TaxInclusive => "شامل الضريبة";
        public static string TaxExclusive => "غير شامل الضريبة";

        // ===== Payment Summary - ملخص الدفع =====
        public static string SubTotal => "المجموع الفرعي";
        public static string Discount => "الخصم";
        public static string Tax => "الضريبة";
        public static string GrandTotal => "الإجمالي النهائي";
        public static string AmountPaid => "المبلغ المدفوع";
        public static string Change => "الباقي";
        public static string Balance => "الرصيد";

        // ===== Receipt Information - معلومات الإيصال =====
        public static string ReceiptNumber => "رقم الإيصال";
        public static string ReceiptDate => "تاريخ الإيصال";
        public static string CashierName => "اسم الكاشير";
        public static string StoreName => "اسم المتجر";
        public static string StoreAddress => "عنوان المتجر";
        public static string StorePhone => "هاتف المتجر";

        // ===== Return/Refund - الإرجاع/الاسترداد =====
        public static string ReturnItem => "إرجاع صنف";
        public static string RefundAmount => "مبلغ الاسترداد";
        public static string ReturnReason => "سبب الإرجاع";
        public static string ProcessReturn => "معالجة الإرجاع";

        // ===== Reports - التقارير =====
        public static string DailySales => "مبيعات اليوم";
        public static string HourlySales => "مبيعات الساعة";
        public static string TopProducts => "أفضل المنتجات";
        public static string SalesByCategory => "المبيعات حسب الفئة";
        public static string SalesByPaymentMethod => "المبيعات حسب طريقة الدفع";

        // ===== Settings - الإعدادات =====
        public static string PosSettings => "إعدادات نقطة البيع";
        public static string ReceiptSettings => "إعدادات الإيصال";
        public static string TaxSettings => "إعدادات الضريبة";
        public static string PaymentSettings => "إعدادات الدفع";
        public static string PrinterSettings => "إعدادات الطابعة";

        // ===== Notifications - الإشعارات =====
        public static string Notification => "إشعار";
        public static string Warning => "تحذير";
        public static string Information => "معلومات";
        public static string Success => "نجح";
        public static string Error => "خطأ";

        // ===== Time and Date - الوقت والتاريخ =====
        public static string Today => "اليوم";
        public static string Yesterday => "أمس";
        public static string ThisWeek => "هذا الأسبوع";
        public static string ThisMonth => "هذا الشهر";
        public static string ThisYear => "هذا العام";

        // ===== Status Messages - رسائل الحالة =====
        public static string Loading => "جاري التحميل...";
        public static string Processing => "جاري المعالجة...";
        public static string Saving => "جاري الحفظ...";
        public static string Printing => "جاري الطباعة...";
        public static string Completed => "مكتمل";
        public static string Failed => "فشل";
        public static string Pending => "قيد الانتظار";
    }
}
