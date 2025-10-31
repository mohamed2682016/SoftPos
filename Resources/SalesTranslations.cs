namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات صفحات المبيعات - Sales Pages Translations
    /// </summary>
    public static class SalesTranslations
    {
        // ===== Sales Invoice List - قائمة فواتير المبيعات =====
        public static class SalesInvoiceList
        {
            public static string Title => "فواتير المبيعات";
            public static string Create => "إنشاء فاتورة";
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

        // ===== Sales Invoice Form - نموذج فاتورة المبيعات =====
        public static class SalesInvoiceForm
        {
            public static string Title => "فاتورة المبيعات";
            public static string CreateNew => "إنشاء فاتورة جديدة";
            public static string EditInvoice => "تعديل الفاتورة";
            public static string InvoiceDetails => "تفاصيل الفاتورة";
            public static string CustomerDetails => "تفاصيل العميل";
            public static string ProductDetails => "تفاصيل المنتجات";
            public static string PaymentDetails => "تفاصيل الدفع";
            public static string AdditionalInfo => "معلومات إضافية";

            // Customer Section
            public static string SelectCustomer => "اختر العميل";
            public static string CustomerInfo => "معلومات العميل";
            public static string CustomerPhone => "هاتف العميل";
            public static string CustomerEmail => "بريد العميل";
            public static string CustomerAddress => "عنوان العميل";
            public static string CustomerBalance => "رصيد العميل";

            // Invoice Details
            public static string InvoiceNumber => "رقم الفاتورة";
            public static string InvoiceDate => "تاريخ الفاتورة";
            public static string DueDate => "تاريخ الاستحقاق";
            public static string Reference => "المرجع";
            public static string Notes => "ملاحظات";
            public static string Terms => "الشروط";

            // Product Section
            public static string AddProduct => "إضافة منتج";
            public static string ProductName => "اسم المنتج";
            public static string ProductCode => "كود المنتج";
            public static string Quantity => "الكمية";
            public static string UnitPrice => "سعر الوحدة";
            public static string Discount => "الخصم";
            public static string Tax => "الضريبة";
            public static string Total => "الإجمالي";
            public static string RemoveProduct => "حذف المنتج";

            // Payment Section
            public static string PaymentMethod => "طريقة الدفع";
            public static string PaymentStatus => "حالة الدفع";
            public static string AmountPaid => "المبلغ المدفوع";
            public static string BalanceDue => "الرصيد المستحق";
            public static string Cash => "نقدي";
            public static string Card => "بطاقة";
            public static string BankTransfer => "تحويل بنكي";
            public static string Cheque => "شيك";

            // Summary Section
            public static string SubTotal => "المجموع الفرعي";
            public static string TotalDiscount => "إجمالي الخصم";
            public static string TotalTax => "إجمالي الضريبة";
            public static string GrandTotal => "الإجمالي النهائي";
            public static string PreviousBalance => "الرصيد السابق";
            public static string NewBalance => "الرصيد الجديد";

            // Actions
            public static string Save => "حفظ";
            public static string SaveAndPrint => "حفظ وطباعة";
            public static string SaveAndNew => "حفظ وجديد";
            public static string Cancel => "إلغاء";
            public static string Print => "طباعة";
            public static string Email => "إرسال بالبريد";
            public static string Preview => "معاينة";
        }

        // ===== Sales Register - سجل المبيعات =====
        public static class SalesRegister
        {
            public static string Title => "سجل المبيعات";
            public static string Date => "التاريخ";
            public static string InvoiceNo => "رقم الفاتورة";
            public static string Customer => "العميل";
            public static string TotalAmount => "المبلغ الإجمالي";
            public static string PaidAmount => "المبلغ المدفوع";
            public static string Balance => "الرصيد";
            public static string PaymentMethod => "طريقة الدفع";
            public static string Status => "الحالة";
            public static string Cashier => "الكاشير";
            public static string Actions => "الإجراءات";
            public static string ViewDetails => "عرض التفاصيل";
            public static string PrintInvoice => "طباعة الفاتورة";
            public static string GeneratePayment => "إنشاء دفعة";
            public static string ProcessReturn => "معالجة الإرجاع";
        }

        // ===== Payment In - المقبوضات =====
        public static class PaymentIn
        {
            public static string Title => "المقبوضات";
            public static string Create => "إنشاء مقبوض";
            public static string PaymentDate => "تاريخ الدفع";
            public static string Customer => "العميل";
            public static string PaymentMethod => "طريقة الدفع";
            public static string Amount => "المبلغ";
            public static string Reference => "المرجع";
            public static string Notes => "ملاحظات";
            public static string BankAccount => "الحساب البنكي";
            public static string ChequeNumber => "رقم الشيك";
            public static string ChequeDate => "تاريخ الشيك";
            public static string BankName => "اسم البنك";
            public static string SavePayment => "حفظ الدفعة";
            public static string PaymentSuccess => "تم حفظ الدفعة بنجاح";
        }

        // ===== Sales Return - مرتجع المبيعات =====
        public static class SalesReturn
        {
            public static string Title => "مرتجع المبيعات";
            public static string Create => "إنشاء مرتجع";
            public static string ReturnDate => "تاريخ الإرجاع";
            public static string OriginalInvoice => "الفاتورة الأصلية";
            public static string Customer => "العميل";
            public static string ReturnReason => "سبب الإرجاع";
            public static string ProductName => "اسم المنتج";
            public static string ReturnedQuantity => "الكمية المرتجعة";
            public static string ReturnAmount => "مبلغ الإرجاع";
            public static string RefundMethod => "طريقة الاسترداد";
            public static string ProcessReturn => "معالجة الإرجاع";
            public static string ReturnSuccess => "تم معالجة الإرجاع بنجاح";
        }

        // ===== Coupon Management - إدارة الكوبونات =====
        public static class Coupon
        {
            public static string Title => "الكوبونات";
            public static string Create => "إنشاء كوبون";
            public static string CouponCode => "كود الكوبون";
            public static string CouponName => "اسم الكوبون";
            public static string DiscountType => "نوع الخصم";
            public static string DiscountValue => "قيمة الخصم";
            public static string MinimumAmount => "الحد الأدنى للمبلغ";
            public static string MaximumDiscount => "الحد الأقصى للخصم";
            public static string ValidFrom => "صالح من";
            public static string ValidTo => "صالح إلى";
            public static string UsageLimit => "حد الاستخدام";
            public static string UsedCount => "عدد الاستخدامات";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string Expired => "منتهي الصلاحية";
        }

        // ===== Sales Reports - تقارير المبيعات =====
        public static class SalesReports
        {
            public static string Title => "تقارير المبيعات";
            public static string DailySales => "مبيعات اليوم";
            public static string WeeklySales => "مبيعات الأسبوع";
            public static string MonthlySales => "مبيعات الشهر";
            public static string YearlySales => "مبيعات السنة";
            public static string SalesByCustomer => "المبيعات حسب العميل";
            public static string SalesByProduct => "المبيعات حسب المنتج";
            public static string SalesByCategory => "المبيعات حسب الفئة";
            public static string TopSellingProducts => "أفضل المنتجات مبيعاً";
            public static string SalesTrend => "اتجاه المبيعات";
            public static string ProfitAnalysis => "تحليل الأرباح";
            public static string GenerateReport => "إنشاء تقرير";
            public static string ExportToExcel => "تصدير إلى Excel";
            public static string PrintReport => "طباعة التقرير";
        }

        // ===== Common Sales Terms - المصطلحات الشائعة =====
        public static class Common
        {
            public static string Sales => "المبيعات";
            public static string Invoice => "الفاتورة";
            public static string Customer => "العميل";
            public static string Product => "المنتج";
            public static string Quantity => "الكمية";
            public static string Price => "السعر";
            public static string Amount => "المبلغ";
            public static string Total => "الإجمالي";
            public static string Discount => "الخصم";
            public static string Tax => "الضريبة";
            public static string Payment => "الدفع";
            public static string Balance => "الرصيد";
            public static string Date => "التاريخ";
            public static string Status => "الحالة";
            public static string Actions => "الإجراءات";
            public static string Create => "إنشاء";
            public static string Edit => "تعديل";
            public static string Delete => "حذف";
            public static string View => "عرض";
            public static string Print => "طباعة";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
        }

        // ===== Validation Messages - رسائل التحقق =====
        public static class Validation
        {
            public static string SelectCustomer => "اختر عميل";
            public static string AddAtLeastOneProduct => "أضف منتج واحد على الأقل";
            public static string InvalidQuantity => "كمية غير صحيحة";
            public static string InvalidPrice => "سعر غير صحيح";
            public static string InvalidDiscount => "خصم غير صحيح";
            public static string InvalidTax => "ضريبة غير صحيحة";
            public static string RequiredField => "هذا الحقل مطلوب";
            public static string InvalidDate => "تاريخ غير صحيح";
            public static string InvalidAmount => "مبلغ غير صحيح";
            public static string CustomerRequired => "العميل مطلوب";
            public static string ProductRequired => "المنتج مطلوب";
            public static string QuantityRequired => "الكمية مطلوبة";
            public static string PriceRequired => "السعر مطلوب";
        }

        // ===== Success Messages - رسائل النجاح =====
        public static class Success
        {
            public static string InvoiceCreated => "تم إنشاء الفاتورة بنجاح";
            public static string InvoiceUpdated => "تم تحديث الفاتورة بنجاح";
            public static string InvoiceDeleted => "تم حذف الفاتورة بنجاح";
            public static string PaymentProcessed => "تمت معالجة الدفعة بنجاح";
            public static string ReturnProcessed => "تمت معالجة الإرجاع بنجاح";
            public static string CouponApplied => "تم تطبيق الكوبون بنجاح";
            public static string DataSaved => "تم حفظ البيانات بنجاح";
            public static string DataUpdated => "تم تحديث البيانات بنجاح";
            public static string DataDeleted => "تم حذف البيانات بنجاح";
        }

        // ===== Error Messages - رسائل الخطأ =====
        public static class Error
        {
            public static string InvoiceNotFound => "الفاتورة غير موجودة";
            public static string CustomerNotFound => "العميل غير موجود";
            public static string ProductNotFound => "المنتج غير موجود";
            public static string InsufficientStock => "مخزون غير كافي";
            public static string InvalidPayment => "دفع غير صحيح";
            public static string CannotDeleteInvoice => "لا يمكن حذف الفاتورة";
            public static string CannotProcessReturn => "لا يمكن معالجة الإرجاع";
            public static string ErrorLoadingData => "خطأ في تحميل البيانات";
            public static string ErrorSavingData => "خطأ في حفظ البيانات";
            public static string ErrorDeletingData => "خطأ في حذف البيانات";
            public static string NetworkError => "خطأ في الشبكة";
            public static string ServerError => "خطأ في الخادم";
        }
    }
}
