namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات صفحات المشتريات - Purchase Pages Translations
    /// </summary>
    public static class PurchaseTranslations
    {
        // ===== Purchase Invoice List - قائمة فواتير المشتريات =====
        public static class PurchaseInvoiceList
        {
            public static string Title => "فواتير المشتريات";
            public static string Create => "إنشاء فاتورة";
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
        }

        // ===== Purchase Invoice Form - نموذج فاتورة المشتريات =====
        public static class PurchaseInvoiceForm
        {
            public static string Title => "فاتورة المشتريات";
            public static string CreateNew => "إنشاء فاتورة جديدة";
            public static string EditInvoice => "تعديل الفاتورة";
            public static string InvoiceDetails => "تفاصيل الفاتورة";
            public static string SupplierDetails => "تفاصيل المورد";
            public static string ProductDetails => "تفاصيل المنتجات";
            public static string PaymentDetails => "تفاصيل الدفع";
            public static string AdditionalInfo => "معلومات إضافية";

            // Supplier Section
            public static string SelectSupplier => "اختر المورد";
            public static string SupplierInfo => "معلومات المورد";
            public static string SupplierPhone => "هاتف المورد";
            public static string SupplierEmail => "بريد المورد";
            public static string SupplierAddress => "عنوان المورد";
            public static string SupplierBalance => "رصيد المورد";

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

        // ===== Payment Out - المدفوعات =====
        public static class PaymentOut
        {
            public static string Title => "المدفوعات";
            public static string Create => "إنشاء دفعة";
            public static string PaymentDate => "تاريخ الدفع";
            public static string Supplier => "المورد";
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

        // ===== Purchase Return - مرتجع المشتريات =====
        public static class PurchaseReturn
        {
            public static string Title => "مرتجع المشتريات";
            public static string Create => "إنشاء مرتجع";
            public static string ReturnDate => "تاريخ الإرجاع";
            public static string OriginalInvoice => "الفاتورة الأصلية";
            public static string Supplier => "المورد";
            public static string ReturnReason => "سبب الإرجاع";
            public static string ProductName => "اسم المنتج";
            public static string ReturnedQuantity => "الكمية المرتجعة";
            public static string ReturnAmount => "مبلغ الإرجاع";
            public static string RefundMethod => "طريقة الاسترداد";
            public static string ProcessReturn => "معالجة الإرجاع";
            public static string ReturnSuccess => "تم معالجة الإرجاع بنجاح";
        }

        // ===== Supplier Management - إدارة الموردين =====
        public static class Supplier
        {
            public static string Title => "الموردين";
            public static string Create => "إنشاء مورد";
            public static string Edit => "تعديل المورد";
            public static string Delete => "حذف المورد";
            public static string List => "قائمة الموردين";
            public static string Add => "إضافة مورد";
            public static string Update => "تحديث المورد";
            public static string Save => "حفظ المورد";
            public static string Cancel => "إلغاء";

            // Supplier Fields
            public static string SupplierName => "اسم المورد";
            public static string SupplierCode => "كود المورد";
            public static string ContactPerson => "الشخص المسؤول";
            public static string Phone => "الهاتف";
            public static string Mobile => "الجوال";
            public static string Email => "البريد الإلكتروني";
            public static string Address => "العنوان";
            public static string City => "المدينة";
            public static string State => "الولاية";
            public static string Country => "الدولة";
            public static string ZipCode => "الرمز البريدي";
            public static string TaxNumber => "الرقم الضريبي";
            public static string CreditLimit => "حد الائتمان";
            public static string PaymentTerms => "شروط الدفع";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";

            // Supplier Details
            public static string SupplierDetails => "تفاصيل المورد";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string ContactInfo => "معلومات الاتصال";
            public static string AddressInfo => "معلومات العنوان";
            public static string FinancialInfo => "المعلومات المالية";
            public static string PurchaseHistory => "تاريخ المشتريات";
            public static string PaymentHistory => "تاريخ المدفوعات";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string ViewPurchases => "عرض المشتريات";
            public static string ViewPayments => "عرض المدفوعات";
            public static string GeneratePayment => "إنشاء دفعة";
        }

        // ===== Purchase Reports - تقارير المشتريات =====
        public static class PurchaseReports
        {
            public static string Title => "تقارير المشتريات";
            public static string DailyPurchases => "مشتريات اليوم";
            public static string WeeklyPurchases => "مشتريات الأسبوع";
            public static string MonthlyPurchases => "مشتريات الشهر";
            public static string YearlyPurchases => "مشتريات السنة";
            public static string PurchasesBySupplier => "المشتريات حسب المورد";
            public static string PurchasesByProduct => "المشتريات حسب المنتج";
            public static string PurchasesByCategory => "المشتريات حسب الفئة";
            public static string TopSuppliers => "أفضل الموردين";
            public static string PurchaseTrend => "اتجاه المشتريات";
            public static string CostAnalysis => "تحليل التكلفة";
            public static string GenerateReport => "إنشاء تقرير";
            public static string ExportToExcel => "تصدير إلى Excel";
            public static string PrintReport => "طباعة التقرير";
        }

        // ===== Purchase Orders - أوامر الشراء =====
        public static class PurchaseOrder
        {
            public static string Title => "أوامر الشراء";
            public static string Create => "إنشاء أمر شراء";
            public static string Edit => "تعديل أمر الشراء";
            public static string Delete => "حذف أمر الشراء";
            public static string List => "قائمة أوامر الشراء";
            public static string Add => "إضافة أمر شراء";
            public static string Update => "تحديث أمر الشراء";
            public static string Save => "حفظ أمر الشراء";
            public static string Cancel => "إلغاء";

            // Purchase Order Fields
            public static string OrderNumber => "رقم الأمر";
            public static string OrderDate => "تاريخ الأمر";
            public static string ExpectedDate => "التاريخ المتوقع";
            public static string Supplier => "المورد";
            public static string Status => "الحالة";
            public static string Pending => "قيد الانتظار";
            public static string Approved => "موافق عليه";
            public static string Rejected => "مرفوض";
            public static string Completed => "مكتمل";
            public static string Cancelled => "ملغي";

            // Purchase Order Details
            public static string OrderDetails => "تفاصيل الأمر";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string SupplierInfo => "معلومات المورد";
            public static string ProductInfo => "معلومات المنتجات";
            public static string DeliveryInfo => "معلومات التسليم";
            public static string PaymentInfo => "معلومات الدفع";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string Approve => "موافقة";
            public static string Reject => "رفض";
            public static string Complete => "إكمال";
        }

        // ===== Receiving - الاستلام =====
        public static class Receiving
        {
            public static string Title => "استلام البضائع";
            public static string Create => "إنشاء استلام";
            public static string Edit => "تعديل الاستلام";
            public static string Delete => "حذف الاستلام";
            public static string List => "قائمة الاستلام";
            public static string Add => "إضافة استلام";
            public static string Update => "تحديث الاستلام";
            public static string Save => "حفظ الاستلام";
            public static string Cancel => "إلغاء";

            // Receiving Fields
            public static string ReceiptNumber => "رقم الاستلام";
            public static string ReceiptDate => "تاريخ الاستلام";
            public static string Supplier => "المورد";
            public static string PurchaseOrder => "أمر الشراء";
            public static string Warehouse => "المستودع";
            public static string ReceivedBy => "استلم بواسطة";
            public static string Status => "الحالة";
            public static string Pending => "قيد الانتظار";
            public static string Received => "مستلم";
            public static string Partial => "جزئي";
            public static string Complete => "مكتمل";

            // Receiving Details
            public static string ReceiptDetails => "تفاصيل الاستلام";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string SupplierInfo => "معلومات المورد";
            public static string ProductInfo => "معلومات المنتجات";
            public static string QualityInfo => "معلومات الجودة";
            public static string StorageInfo => "معلومات التخزين";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string Receive => "استلام";
            public static string QualityCheck => "فحص الجودة";
            public static string Store => "تخزين";
        }

        // ===== Common Purchase Terms - المصطلحات الشائعة =====
        public static class Common
        {
            public static string Purchase => "المشتريات";
            public static string Invoice => "الفاتورة";
            public static string Supplier => "المورد";
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
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
        }

        // ===== Validation Messages - رسائل التحقق =====
        public static class Validation
        {
            public static string SelectSupplier => "اختر مورد";
            public static string AddAtLeastOneProduct => "أضف منتج واحد على الأقل";
            public static string InvalidQuantity => "كمية غير صحيحة";
            public static string InvalidPrice => "سعر غير صحيح";
            public static string InvalidDiscount => "خصم غير صحيح";
            public static string InvalidTax => "ضريبة غير صحيحة";
            public static string RequiredField => "هذا الحقل مطلوب";
            public static string InvalidDate => "تاريخ غير صحيح";
            public static string InvalidAmount => "مبلغ غير صحيح";
            public static string SupplierRequired => "المورد مطلوب";
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
            public static string SupplierCreated => "تم إنشاء المورد بنجاح";
            public static string SupplierUpdated => "تم تحديث المورد بنجاح";
            public static string SupplierDeleted => "تم حذف المورد بنجاح";
            public static string OrderCreated => "تم إنشاء الأمر بنجاح";
            public static string OrderUpdated => "تم تحديث الأمر بنجاح";
            public static string OrderDeleted => "تم حذف الأمر بنجاح";
            public static string ReceiptCreated => "تم إنشاء الاستلام بنجاح";
            public static string ReceiptUpdated => "تم تحديث الاستلام بنجاح";
            public static string ReceiptDeleted => "تم حذف الاستلام بنجاح";
            public static string DataSaved => "تم حفظ البيانات بنجاح";
            public static string DataUpdated => "تم تحديث البيانات بنجاح";
            public static string DataDeleted => "تم حذف البيانات بنجاح";
        }

        // ===== Error Messages - رسائل الخطأ =====
        public static class Error
        {
            public static string InvoiceNotFound => "الفاتورة غير موجودة";
            public static string SupplierNotFound => "المورد غير موجود";
            public static string ProductNotFound => "المنتج غير موجود";
            public static string InsufficientStock => "مخزون غير كافي";
            public static string InvalidPayment => "دفع غير صحيح";
            public static string CannotDeleteInvoice => "لا يمكن حذف الفاتورة";
            public static string CannotProcessReturn => "لا يمكن معالجة الإرجاع";
            public static string CannotDeleteSupplier => "لا يمكن حذف المورد";
            public static string CannotDeleteOrder => "لا يمكن حذف الأمر";
            public static string CannotDeleteReceipt => "لا يمكن حذف الاستلام";
            public static string ErrorLoadingData => "خطأ في تحميل البيانات";
            public static string ErrorSavingData => "خطأ في حفظ البيانات";
            public static string ErrorDeletingData => "خطأ في حذف البيانات";
            public static string NetworkError => "خطأ في الشبكة";
            public static string ServerError => "خطأ في الخادم";
        }
    }
}
