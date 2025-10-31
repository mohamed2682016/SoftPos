namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات الرسائل والتنبيهات - Message Translations
    /// </summary>
    public static class MessageTranslations
    {
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
        }

        // ===== Confirmation Messages - رسائل التأكيد =====
        public static class Confirmation
        {
            public static string ConfirmDelete => "هل أنت متأكد من الحذف؟";
            public static string ConfirmCancel => "هل أنت متأكد من الإلغاء؟";
            public static string ConfirmSave => "هل تريد حفظ التغييرات؟";
            public static string ConfirmExit => "هل تريد الخروج؟";
            public static string ConfirmPayment => "هل تريد تأكيد الدفعة؟";
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
        }

        // ===== Specific Messages - رسائل محددة =====
        
        // Company Messages
        public static string CompanyUpdatedSuccessfully => "تم تحديث الشركة بنجاح";
        public static string CompanyNameAlreadyExists => "اسم الشركة موجود مسبقاً";
        public static string ErrorSaving => "خطأ في الحفظ";
        
        // Coupon Messages
        public static string CouponCreatedSuccessfully => "تم إنشاء الكوبون بنجاح";
        public static string CouponUpdatedSuccessfully => "تم تحديث الكوبون بنجاح";
        public static string CouponDeletedSuccessfully => "تم حذف الكوبون بنجاح";
        public static string CouponNameAlreadyExists => "اسم الكوبون موجود مسبقاً";
        public static string CouponCannotBeDeleted => "لا يمكن حذف الكوبون لأنه قيد الاستخدام";
        public static string AreYouSureDeleteCoupon => "هل أنت متأكد من حذف هذا الكوبون؟";
        
        // Currency Messages
        public static string CurrencyCreatedSuccessfully => "تم إنشاء العملة بنجاح";
        public static string CurrencyUpdatedSuccessfully => "تم تحديث العملة بنجاح";
        public static string CurrencyDeletedSuccessfully => "تم حذف العملة بنجاح";
        public static string CurrencyNameAlreadyExists => "اسم العملة موجود مسبقاً";
        public static string CurrencyCannotBeDeleted => "لا يمكن حذف العملة لأنها قيد الاستخدام";
        public static string AreYouSureDeleteCurrency => "هل أنت متأكد من حذف هذه العملة؟";
        
        // Financial Year Messages
        public static string FinancialYearCreatedSuccessfully => "تم إنشاء السنة المالية بنجاح";
        public static string FinancialYearAlreadyExists => "السنة المالية موجودة مسبقاً";
        public static string FiscalYearChangedSuccessfully => "تم تغيير السنة المالية بنجاح";
        public static string Failed => "فشل";
        
        // Invoice Setting Messages
        public static string InvoiceSettingUpdatedSuccessfully => "تم تحديث إعدادات الفاتورة بنجاح";
        public static string InvoiceSettingAlreadyExists => "إعدادات الفاتورة موجودة مسبقاً";
    }
}
