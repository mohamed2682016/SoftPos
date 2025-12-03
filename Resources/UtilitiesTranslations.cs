namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات صفحات الأدوات - Utilities Pages Translations
    /// </summary>
    public static class UtilitiesTranslations
    {
        // ===== Barcode Generator - مولد الباركود =====
        public static class BarcodeGenerator
        {
            public static string Title => "مولد الباركود";
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
            public static string BarcodeTypes => "أنواع الباركود";
            public static string Code128 => "Code 128";
            public static string Code39 => "Code 39";
            public static string EAN13 => "EAN 13";
            public static string EAN8 => "EAN 8";
            public static string UPC => "UPC";
            public static string QRCode => "QR Code";
            public static string DataMatrix => "Data Matrix";
            public static string PDF417 => "PDF 417";
        }

        // ===== Import Items - استيراد الأصناف =====
        public static class ImportItems
        {
            public static string Title => "استيراد الأصناف";
            public static string SelectFile => "اختر الملف";
            public static string UploadFile => "رفع الملف";
            public static string FileFormat => "تنسيق الملف";
            public static string ExcelFile => "ملف Excel";
            public static string CSVFile => "ملف CSV";
            public static string XMLFile => "ملف XML";
            public static string JSONFile => "ملف JSON";
            public static string ImportData => "استيراد البيانات";
            public static string PreviewData => "معاينة البيانات";
            public static string ValidateData => "التحقق من البيانات";
            public static string ImportSuccess => "تم الاستيراد بنجاح";
            public static string ImportFailed => "فشل في الاستيراد";
            public static string InvalidFileFormat => "تنسيق ملف غير صحيح";
            public static string FileTooLarge => "الملف كبير جداً";
            public static string NoDataFound => "لا توجد بيانات";
            public static string DataValidationFailed => "فشل في التحقق من البيانات";
            public static string ImportProgress => "تقدم الاستيراد";
            public static string ImportedItems => "الأصناف المستوردة";
            public static string FailedItems => "الأصناف الفاشلة";
            public static string SkippedItems => "الأصناف المتجاهلة";
            public static string TotalItems => "إجمالي الأصناف";
            public static string ImportSummary => "ملخص الاستيراد";
        }

        // ===== Backup and Restore - النسخ الاحتياطي والاستعادة =====
        public static class BackupRestore
        {
            public static string Title => "النسخ الاحتياطي والاستعادة";
            public static string Backup => "نسخ احتياطي";
            public static string Restore => "استعادة";
            public static string CreateBackup => "إنشاء نسخ احتياطي";
            public static string RestoreBackup => "استعادة النسخ الاحتياطي";
            public static string BackupLocation => "موقع النسخ الاحتياطي";
            public static string BackupName => "اسم النسخ الاحتياطي";
            public static string BackupDate => "تاريخ النسخ الاحتياطي";
            public static string BackupSize => "حجم النسخ الاحتياطي";
            public static string BackupStatus => "حالة النسخ الاحتياطي";
            public static string BackupSuccess => "تم إنشاء النسخ الاحتياطي بنجاح";
            public static string BackupFailed => "فشل في إنشاء النسخ الاحتياطي";
            public static string RestoreSuccess => "تم استعادة النسخ الاحتياطي بنجاح";
            public static string RestoreFailed => "فشل في استعادة النسخ الاحتياطي";
            public static string BackupInProgress => "جاري إنشاء النسخ الاحتياطي";
            public static string RestoreInProgress => "جاري استعادة النسخ الاحتياطي";
            public static string BackupCompleted => "تم إنشاء النسخ الاحتياطي";
            public static string RestoreCompleted => "تم استعادة النسخ الاحتياطي";
            public static string BackupList => "قائمة النسخ الاحتياطية";
            public static string SelectBackup => "اختر النسخ الاحتياطي";
            public static string DeleteBackup => "حذف النسخ الاحتياطي";
            public static string DownloadBackup => "تحميل النسخ الاحتياطي";
            public static string UploadBackup => "رفع النسخ الاحتياطي";
        }

        // ===== Data Export - تصدير البيانات =====
        public static class DataExport
        {
            public static string Title => "تصدير البيانات";
            public static string ExportData => "تصدير البيانات";
            public static string ExportFormat => "تنسيق التصدير";
            public static string ExportType => "نوع التصدير";
            public static string ExportAll => "تصدير الكل";
            public static string ExportSelected => "تصدير المحدد";
            public static string ExportFiltered => "تصدير المفلتر";
            public static string ExportDateRange => "تصدير نطاق التاريخ";
            public static string ExportFields => "حقول التصدير";
            public static string SelectFields => "اختر الحقول";
            public static string AllFields => "كل الحقول";
            public static string CustomFields => "حقول مخصصة";
            public static string ExportOptions => "خيارات التصدير";
            public static string IncludeHeaders => "تضمين العناوين";
            public static string IncludeFooters => "تضمين التذييلات";
            public static string IncludeImages => "تضمين الصور";
            public static string ExportSuccess => "تم التصدير بنجاح";
            public static string ExportFailed => "فشل في التصدير";
            public static string ExportInProgress => "جاري التصدير";
            public static string ExportCompleted => "تم التصدير";
            public static string ExportSummary => "ملخص التصدير";
            public static string ExportedRecords => "السجلات المصدرة";
            public static string ExportFile => "ملف التصدير";
            public static string DownloadExport => "تحميل التصدير";
            public static string EmailExport => "إرسال التصدير بالبريد";
        }

        // ===== Data Import - استيراد البيانات =====
        public static class DataImport
        {
            public static string Title => "استيراد البيانات";
            public static string ImportData => "استيراد البيانات";
            public static string ImportFormat => "تنسيق الاستيراد";
            public static string ImportType => "نوع الاستيراد";
            public static string ImportFile => "ملف الاستيراد";
            public static string SelectFile => "اختر الملف";
            public static string UploadFile => "رفع الملف";
            public static string FileValidation => "التحقق من الملف";
            public static string DataMapping => "ربط البيانات";
            public static string FieldMapping => "ربط الحقول";
            public static string DataPreview => "معاينة البيانات";
            public static string ImportOptions => "خيارات الاستيراد";
            public static string SkipDuplicates => "تجاهل المكررات";
            public static string UpdateExisting => "تحديث الموجود";
            public static string CreateNew => "إنشاء جديد";
            public static string ImportSuccess => "تم الاستيراد بنجاح";
            public static string ImportFailed => "فشل في الاستيراد";
            public static string ImportInProgress => "جاري الاستيراد";
            public static string ImportCompleted => "تم الاستيراد";
            public static string ImportSummary => "ملخص الاستيراد";
            public static string ImportedRecords => "السجلات المستوردة";
            public static string FailedRecords => "السجلات الفاشلة";
            public static string SkippedRecords => "السجلات المتجاهلة";
            public static string TotalRecords => "إجمالي السجلات";
        }

        // ===== System Maintenance - صيانة النظام =====
        public static class SystemMaintenance
        {
            public static string Title => "صيانة النظام";
            public static string DatabaseMaintenance => "صيانة قاعدة البيانات";
            public static string CacheMaintenance => "صيانة التخزين المؤقت";
            public static string LogMaintenance => "صيانة السجلات";
            public static string FileMaintenance => "صيانة الملفات";
            public static string SystemOptimization => "تحسين النظام";
            public static string PerformanceMonitoring => "مراقبة الأداء";
            public static string ErrorLogging => "تسجيل الأخطاء";
            public static string SecurityScan => "فحص الأمان";
            public static string UpdateCheck => "فحص التحديثات";
            public static string BackupSchedule => "جدولة النسخ الاحتياطي";
            public static string MaintenanceSchedule => "جدولة الصيانة";
            public static string SystemStatus => "حالة النظام";
            public static string SystemHealth => "صحة النظام";
            public static string SystemPerformance => "أداء النظام";
            public static string SystemResources => "موارد النظام";
            public static string SystemLogs => "سجلات النظام";
            public static string SystemErrors => "أخطاء النظام";
            public static string SystemWarnings => "تحذيرات النظام";
            public static string SystemInfo => "معلومات النظام";
        }

        // ===== Email Service - خدمة البريد الإلكتروني =====
        public static class EmailService
        {
            public static string Title => "خدمة البريد الإلكتروني";
            public static string SendEmail => "إرسال بريد إلكتروني";
            public static string EmailTemplate => "قالب البريد الإلكتروني";
            public static string EmailRecipients => "مستلمي البريد الإلكتروني";
            public static string EmailSubject => "موضوع البريد الإلكتروني";
            public static string EmailBody => "محتوى البريد الإلكتروني";
            public static string EmailAttachment => "مرفق البريد الإلكتروني";
            public static string EmailPriority => "أولوية البريد الإلكتروني";
            public static string EmailStatus => "حالة البريد الإلكتروني";
            public static string EmailSent => "تم إرسال البريد الإلكتروني";
            public static string EmailFailed => "فشل في إرسال البريد الإلكتروني";
            public static string EmailPending => "البريد الإلكتروني قيد الانتظار";
            public static string EmailDelivered => "تم تسليم البريد الإلكتروني";
            public static string EmailBounced => "ارتد البريد الإلكتروني";
            public static string EmailOpened => "تم فتح البريد الإلكتروني";
            public static string EmailClicked => "تم النقر على البريد الإلكتروني";
            public static string EmailUnsubscribed => "تم إلغاء الاشتراك";
            public static string EmailComplained => "تم التبليغ عن البريد الإلكتروني";
            public static string EmailList => "قائمة البريد الإلكتروني";
            public static string EmailHistory => "تاريخ البريد الإلكتروني";
            public static string EmailReports => "تقارير البريد الإلكتروني";
        }

        // ===== SMS Service - خدمة الرسائل النصية =====
        public static class SMSService
        {
            public static string Title => "خدمة الرسائل النصية";
            public static string SendSMS => "إرسال رسالة نصية";
            public static string SMSRecipients => "مستلمي الرسالة النصية";
            public static string SMSMessage => "نص الرسالة";
            public static string SMSStatus => "حالة الرسالة النصية";
            public static string SMSSent => "تم إرسال الرسالة النصية";
            public static string SMSFailed => "فشل في إرسال الرسالة النصية";
            public static string SMSPending => "الرسالة النصية قيد الانتظار";
            public static string SMSDelivered => "تم تسليم الرسالة النصية";
            public static string SMSBounced => "ارتدت الرسالة النصية";
            public static string SMSList => "قائمة الرسائل النصية";
            public static string SMSHistory => "تاريخ الرسائل النصية";
            public static string SMSReports => "تقارير الرسائل النصية";
            public static string SMSTemplate => "قالب الرسالة النصية";
            public static string SMSBulk => "رسائل نصية جماعية";
            public static string SMSSchedule => "جدولة الرسائل النصية";
        }

        // ===== Notification Service - خدمة الإشعارات =====
        public static class NotificationService
        {
            public static string Title => "خدمة الإشعارات";
            public static string SendNotification => "إرسال إشعار";
            public static string NotificationType => "نوع الإشعار";
            public static string NotificationMessage => "رسالة الإشعار";
            public static string NotificationRecipients => "مستلمي الإشعار";
            public static string NotificationStatus => "حالة الإشعار";
            public static string NotificationSent => "تم إرسال الإشعار";
            public static string NotificationFailed => "فشل في إرسال الإشعار";
            public static string NotificationPending => "الإشعار قيد الانتظار";
            public static string NotificationDelivered => "تم تسليم الإشعار";
            public static string NotificationRead => "تم قراءة الإشعار";
            public static string NotificationList => "قائمة الإشعارات";
            public static string NotificationHistory => "تاريخ الإشعارات";
            public static string NotificationReports => "تقارير الإشعارات";
            public static string NotificationSettings => "إعدادات الإشعارات";
            public static string NotificationPreferences => "تفضيلات الإشعارات";
        }

        // ===== Common Utilities Terms - المصطلحات الشائعة =====
        public static class Common
        {
            public static string Utilities => "الأدوات";
            public static string Tools => "الأدوات";
            public static string Services => "الخدمات";
            public static string Functions => "الوظائف";
            public static string Features => "الميزات";
            public static string Options => "الخيارات";
            public static string Settings => "الإعدادات";
            public static string Configuration => "التكوين";
            public static string Maintenance => "الصيانة";
            public static string Backup => "النسخ الاحتياطي";
            public static string Restore => "الاستعادة";
            public static string Import => "الاستيراد";
            public static string Export => "التصدير";
            public static string Generate => "إنشاء";
            public static string Create => "إنشاء";
            public static string Edit => "تعديل";
            public static string Delete => "حذف";
            public static string View => "عرض";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Print => "طباعة";
            public static string Download => "تحميل";
            public static string Upload => "رفع";
            public static string Send => "إرسال";
            public static string Receive => "استقبال";
            public static string Process => "معالجة";
            public static string Execute => "تنفيذ";
            public static string Run => "تشغيل";
            public static string Start => "بدء";
            public static string Stop => "إيقاف";
            public static string Pause => "إيقاف مؤقت";
            public static string Resume => "استئناف";
            public static string Complete => "إكمال";
            public static string Finish => "إنهاء";
            public static string Success => "نجح";
            public static string Failed => "فشل";
            public static string Error => "خطأ";
            public static string Warning => "تحذير";
            public static string Info => "معلومات";
            public static string Status => "الحالة";
            public static string Progress => "التقدم";
            public static string Loading => "جاري التحميل";
            public static string Processing => "جاري المعالجة";
            public static string Completed => "مكتمل";
            public static string Pending => "قيد الانتظار";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
        }

        // ===== Validation Messages - رسائل التحقق =====
        public static class Validation
        {
            public static string FileRequired => "الملف مطلوب";
            public static string InvalidFileFormat => "تنسيق ملف غير صحيح";
            public static string FileTooLarge => "الملف كبير جداً";
            public static string InvalidData => "بيانات غير صحيحة";
            public static string RequiredField => "هذا الحقل مطلوب";
            public static string InvalidEmail => "بريد إلكتروني غير صحيح";
            public static string InvalidPhone => "رقم هاتف غير صحيح";
            public static string InvalidDate => "تاريخ غير صحيح";
            public static string InvalidTime => "وقت غير صحيح";
            public static string InvalidNumber => "رقم غير صحيح";
            public static string InvalidText => "نص غير صحيح";
            public static string InvalidSelection => "اختيار غير صحيح";
            public static string NoDataFound => "لا توجد بيانات";
            public static string DataValidationFailed => "فشل في التحقق من البيانات";
            public static string FileValidationFailed => "فشل في التحقق من الملف";
            public static string DataMappingFailed => "فشل في ربط البيانات";
            public static string ImportValidationFailed => "فشل في التحقق من الاستيراد";
            public static string ExportValidationFailed => "فشل في التحقق من التصدير";
        }

        // ===== Success Messages - رسائل النجاح =====
        public static class Success
        {
            public static string BarcodeGenerated => "تم إنشاء الباركود بنجاح";
            public static string DataImported => "تم استيراد البيانات بنجاح";
            public static string DataExported => "تم تصدير البيانات بنجاح";
            public static string BackupCreated => "تم إنشاء النسخ الاحتياطي بنجاح";
            public static string BackupRestored => "تم استعادة النسخ الاحتياطي بنجاح";
            public static string EmailSent => "تم إرسال البريد الإلكتروني بنجاح";
            public static string SMSSent => "تم إرسال الرسالة النصية بنجاح";
            public static string NotificationSent => "تم إرسال الإشعار بنجاح";
            public static string SystemOptimized => "تم تحسين النظام بنجاح";
            public static string MaintenanceCompleted => "تمت الصيانة بنجاح";
            public static string DataProcessed => "تمت معالجة البيانات بنجاح";
            public static string TaskCompleted => "تم إكمال المهمة بنجاح";
            public static string OperationCompleted => "تم إكمال العملية بنجاح";
            public static string DataSaved => "تم حفظ البيانات بنجاح";
            public static string DataUpdated => "تم تحديث البيانات بنجاح";
            public static string DataDeleted => "تم حذف البيانات بنجاح";
        }

        // ===== Error Messages - رسائل الخطأ =====
        public static class Error
        {
            public static string BarcodeGenerationFailed => "فشل في إنشاء الباركود";
            public static string DataImportFailed => "فشل في استيراد البيانات";
            public static string DataExportFailed => "فشل في تصدير البيانات";
            public static string BackupCreationFailed => "فشل في إنشاء النسخ الاحتياطي";
            public static string BackupRestoreFailed => "فشل في استعادة النسخ الاحتياطي";
            public static string EmailSendingFailed => "فشل في إرسال البريد الإلكتروني";
            public static string SMSSendingFailed => "فشل في إرسال الرسالة النصية";
            public static string NotificationSendingFailed => "فشل في إرسال الإشعار";
            public static string SystemOptimizationFailed => "فشل في تحسين النظام";
            public static string MaintenanceFailed => "فشلت الصيانة";
            public static string DataProcessingFailed => "فشلت معالجة البيانات";
            public static string TaskFailed => "فشلت المهمة";
            public static string OperationFailed => "فشلت العملية";
            public static string ErrorLoadingData => "خطأ في تحميل البيانات";
            public static string ErrorSavingData => "خطأ في حفظ البيانات";
            public static string ErrorDeletingData => "خطأ في حذف البيانات";
            public static string NetworkError => "خطأ في الشبكة";
            public static string ServerError => "خطأ في الخادم";
            public static string FileNotFound => "الملف غير موجود";
            public static string AccessDenied => "تم رفض الوصول";
            public static string PermissionDenied => "تم رفض الإذن";
            public static string InvalidOperation => "عملية غير صحيحة";
            public static string SystemError => "خطأ في النظام";
        }
    }
}


