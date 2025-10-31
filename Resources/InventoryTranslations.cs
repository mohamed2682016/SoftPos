namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات صفحات إدارة المخزون - Inventory Management Translations
    /// </summary>
    public static class InventoryTranslations
    {
        // ===== Product Management - إدارة المنتجات =====
        public static class Product
        {
            public static string Title => "المنتجات";
            public static string Create => "إنشاء منتج";
            public static string Edit => "تعديل المنتج";
            public static string Delete => "حذف المنتج";
            public static string View => "عرض المنتج";
            public static string List => "قائمة المنتجات";
            public static string Add => "إضافة منتج";
            public static string Update => "تحديث المنتج";
            public static string Save => "حفظ المنتج";
            public static string Cancel => "إلغاء";

            // Product Fields
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

            // Stock Information
            public static string CurrentStock => "المخزون الحالي";
            public static string MinimumStock => "الحد الأدنى للمخزون";
            public static string MaximumStock => "الحد الأقصى للمخزون";
            public static string ReorderLevel => "مستوى إعادة الطلب";
            public static string StockValue => "قيمة المخزون";
            public static string InStock => "متوفر";
            public static string OutOfStock => "غير متوفر";
            public static string LowStock => "مخزون منخفض";
            public static string OverStock => "مخزون زائد";

            // Product Details
            public static string ProductDetails => "تفاصيل المنتج";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string PricingInfo => "معلومات التسعير";
            public static string StockInfo => "معلومات المخزون";
            public static string TaxInfo => "معلومات الضريبة";
            public static string AdditionalInfo => "معلومات إضافية";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string GenerateBarcode => "إنشاء باركود";
            public static string UpdateStock => "تحديث المخزون";
            public static string StockAdjustment => "تعديل المخزون";
        }

        // ===== Category Management - إدارة الفئات =====
        public static class Category
        {
            public static string Title => "الفئات";
            public static string Create => "إنشاء فئة";
            public static string Edit => "تعديل الفئة";
            public static string Delete => "حذف الفئة";
            public static string List => "قائمة الفئات";
            public static string Add => "إضافة فئة";
            public static string Update => "تحديث الفئة";
            public static string Save => "حفظ الفئة";
            public static string Cancel => "إلغاء";

            // Category Fields
            public static string CategoryName => "اسم الفئة";
            public static string CategoryCode => "كود الفئة";
            public static string Description => "الوصف";
            public static string ParentCategory => "الفئة الرئيسية";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string Image => "الصورة";
            public static string Icon => "الأيقونة";

            // Category Details
            public static string CategoryDetails => "تفاصيل الفئة";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string Hierarchy => "التسلسل الهرمي";
            public static string Products => "المنتجات";
            public static string ProductCount => "عدد المنتجات";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string ViewProducts => "عرض المنتجات";
        }

        // ===== Brand Management - إدارة العلامات التجارية =====
        public static class Brand
        {
            public static string Title => "العلامات التجارية";
            public static string Create => "إنشاء علامة تجارية";
            public static string Edit => "تعديل العلامة التجارية";
            public static string Delete => "حذف العلامة التجارية";
            public static string List => "قائمة العلامات التجارية";
            public static string Add => "إضافة علامة تجارية";
            public static string Update => "تحديث العلامة التجارية";
            public static string Save => "حفظ العلامة التجارية";
            public static string Cancel => "إلغاء";

            // Brand Fields
            public static string BrandName => "اسم العلامة التجارية";
            public static string BrandCode => "كود العلامة التجارية";
            public static string Description => "الوصف";
            public static string Logo => "الشعار";
            public static string Website => "الموقع الإلكتروني";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";

            // Brand Details
            public static string BrandDetails => "تفاصيل العلامة التجارية";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string ContactInfo => "معلومات الاتصال";
            public static string Products => "المنتجات";
            public static string ProductCount => "عدد المنتجات";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string ViewProducts => "عرض المنتجات";
        }

        // ===== Unit Management - إدارة الوحدات =====
        public static class Unit
        {
            public static string Title => "الوحدات";
            public static string Create => "إنشاء وحدة";
            public static string Edit => "تعديل الوحدة";
            public static string Delete => "حذف الوحدة";
            public static string List => "قائمة الوحدات";
            public static string Add => "إضافة وحدة";
            public static string Update => "تحديث الوحدة";
            public static string Save => "حفظ الوحدة";
            public static string Cancel => "إلغاء";

            // Unit Fields
            public static string UnitName => "اسم الوحدة";
            public static string UnitCode => "كود الوحدة";
            public static string ShortName => "الاسم المختصر";
            public static string Description => "الوصف";
            public static string BaseUnit => "الوحدة الأساسية";
            public static string ConversionFactor => "معامل التحويل";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";

            // Unit Details
            public static string UnitDetails => "تفاصيل الوحدة";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string ConversionInfo => "معلومات التحويل";
            public static string Products => "المنتجات";
            public static string ProductCount => "عدد المنتجات";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string ViewProducts => "عرض المنتجات";
        }

        // ===== Warehouse Management - إدارة المستودعات =====
        public static class Warehouse
        {
            public static string Title => "المستودعات";
            public static string Create => "إنشاء مستودع";
            public static string Edit => "تعديل المستودع";
            public static string Delete => "حذف المستودع";
            public static string List => "قائمة المستودعات";
            public static string Add => "إضافة مستودع";
            public static string Update => "تحديث المستودع";
            public static string Save => "حفظ المستودع";
            public static string Cancel => "إلغاء";

            // Warehouse Fields
            public static string WarehouseName => "اسم المستودع";
            public static string WarehouseCode => "كود المستودع";
            public static string Description => "الوصف";
            public static string Address => "العنوان";
            public static string City => "المدينة";
            public static string State => "الولاية";
            public static string Country => "الدولة";
            public static string ZipCode => "الرمز البريدي";
            public static string Phone => "الهاتف";
            public static string Email => "البريد الإلكتروني";
            public static string Manager => "المدير";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";

            // Warehouse Details
            public static string WarehouseDetails => "تفاصيل المستودع";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string ContactInfo => "معلومات الاتصال";
            public static string LocationInfo => "معلومات الموقع";
            public static string StockInfo => "معلومات المخزون";
            public static string Products => "المنتجات";
            public static string ProductCount => "عدد المنتجات";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string ViewStock => "عرض المخزون";
            public static string StockReport => "تقرير المخزون";
        }

        // ===== Tax Management - إدارة الضرائب =====
        public static class Tax
        {
            public static string Title => "الضرائب";
            public static string Create => "إنشاء ضريبة";
            public static string Edit => "تعديل الضريبة";
            public static string Delete => "حذف الضريبة";
            public static string List => "قائمة الضرائب";
            public static string Add => "إضافة ضريبة";
            public static string Update => "تحديث الضريبة";
            public static string Save => "حفظ الضريبة";
            public static string Cancel => "إلغاء";

            // Tax Fields
            public static string TaxName => "اسم الضريبة";
            public static string TaxCode => "كود الضريبة";
            public static string TaxRate => "معدل الضريبة";
            public static string TaxType => "نوع الضريبة";
            public static string Description => "الوصف";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string Inclusive => "شامل";
            public static string Exclusive => "غير شامل";

            // Tax Details
            public static string TaxDetails => "تفاصيل الضريبة";
            public static string BasicInfo => "المعلومات الأساسية";
            public static string RateInfo => "معلومات المعدل";
            public static string TypeInfo => "معلومات النوع";
            public static string Products => "المنتجات";
            public static string ProductCount => "عدد المنتجات";

            // Actions
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string ViewProducts => "عرض المنتجات";
        }

        // ===== Stock Management - إدارة المخزون =====
        public static class Stock
        {
            public static string Title => "إدارة المخزون";
            public static string StockReport => "تقرير المخزون";
            public static string StockAdjustment => "تعديل المخزون";
            public static string StockTransfer => "نقل المخزون";
            public static string StockCount => "جرد المخزون";
            public static string LowStockReport => "تقرير المخزون المنخفض";
            public static string OutOfStockReport => "تقرير المخزون المنتهي";

            // Stock Fields
            public static string ProductName => "اسم المنتج";
            public static string ProductCode => "كود المنتج";
            public static string CurrentStock => "المخزون الحالي";
            public static string MinimumStock => "الحد الأدنى";
            public static string MaximumStock => "الحد الأقصى";
            public static string ReorderLevel => "مستوى إعادة الطلب";
            public static string StockValue => "قيمة المخزون";
            public static string LastUpdated => "آخر تحديث";
            public static string Status => "الحالة";

            // Stock Actions
            public static string AddStock => "إضافة مخزون";
            public static string RemoveStock => "إزالة مخزون";
            public static string TransferStock => "نقل مخزون";
            public static string AdjustStock => "تعديل مخزون";
            public static string CountStock => "جرد مخزون";
            public static string UpdateStock => "تحديث مخزون";

            // Stock Status
            public static string InStock => "متوفر";
            public static string OutOfStock => "غير متوفر";
            public static string LowStock => "مخزون منخفض";
            public static string OverStock => "مخزون زائد";
            public static string CriticalStock => "مخزون حرج";
        }

        // ===== Common Inventory Terms - المصطلحات الشائعة =====
        public static class Common
        {
            public static string Inventory => "المخزون";
            public static string Product => "المنتج";
            public static string Category => "الفئة";
            public static string Brand => "العلامة التجارية";
            public static string Unit => "الوحدة";
            public static string Warehouse => "المستودع";
            public static string Tax => "الضريبة";
            public static string Stock => "المخزون";
            public static string Quantity => "الكمية";
            public static string Price => "السعر";
            public static string Amount => "المبلغ";
            public static string Total => "الإجمالي";
            public static string Status => "الحالة";
            public static string Actions => "الإجراءات";
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
        }

        // ===== Validation Messages - رسائل التحقق =====
        public static class Validation
        {
            public static string ProductNameRequired => "اسم المنتج مطلوب";
            public static string ProductCodeRequired => "كود المنتج مطلوب";
            public static string CategoryRequired => "الفئة مطلوبة";
            public static string BrandRequired => "العلامة التجارية مطلوبة";
            public static string UnitRequired => "الوحدة مطلوبة";
            public static string PriceRequired => "السعر مطلوب";
            public static string QuantityRequired => "الكمية مطلوبة";
            public static string InvalidPrice => "سعر غير صحيح";
            public static string InvalidQuantity => "كمية غير صحيحة";
            public static string InvalidDiscount => "خصم غير صحيح";
            public static string InvalidTax => "ضريبة غير صحيحة";
            public static string RequiredField => "هذا الحقل مطلوب";
            public static string InvalidData => "بيانات غير صحيحة";
            public static string DuplicateCode => "الكود موجود مسبقاً";
            public static string DuplicateName => "الاسم موجود مسبقاً";
        }

        // ===== Success Messages - رسائل النجاح =====
        public static class Success
        {
            public static string ProductCreated => "تم إنشاء المنتج بنجاح";
            public static string ProductUpdated => "تم تحديث المنتج بنجاح";
            public static string ProductDeleted => "تم حذف المنتج بنجاح";
            public static string CategoryCreated => "تم إنشاء الفئة بنجاح";
            public static string CategoryUpdated => "تم تحديث الفئة بنجاح";
            public static string CategoryDeleted => "تم حذف الفئة بنجاح";
            public static string BrandCreated => "تم إنشاء العلامة التجارية بنجاح";
            public static string BrandUpdated => "تم تحديث العلامة التجارية بنجاح";
            public static string BrandDeleted => "تم حذف العلامة التجارية بنجاح";
            public static string UnitCreated => "تم إنشاء الوحدة بنجاح";
            public static string UnitUpdated => "تم تحديث الوحدة بنجاح";
            public static string UnitDeleted => "تم حذف الوحدة بنجاح";
            public static string WarehouseCreated => "تم إنشاء المستودع بنجاح";
            public static string WarehouseUpdated => "تم تحديث المستودع بنجاح";
            public static string WarehouseDeleted => "تم حذف المستودع بنجاح";
            public static string TaxCreated => "تم إنشاء الضريبة بنجاح";
            public static string TaxUpdated => "تم تحديث الضريبة بنجاح";
            public static string TaxDeleted => "تم حذف الضريبة بنجاح";
            public static string StockUpdated => "تم تحديث المخزون بنجاح";
            public static string DataSaved => "تم حفظ البيانات بنجاح";
            public static string DataUpdated => "تم تحديث البيانات بنجاح";
            public static string DataDeleted => "تم حذف البيانات بنجاح";
        }

        // ===== Error Messages - رسائل الخطأ =====
        public static class Error
        {
            public static string ProductNotFound => "المنتج غير موجود";
            public static string CategoryNotFound => "الفئة غير موجودة";
            public static string BrandNotFound => "العلامة التجارية غير موجودة";
            public static string UnitNotFound => "الوحدة غير موجودة";
            public static string WarehouseNotFound => "المستودع غير موجود";
            public static string TaxNotFound => "الضريبة غير موجودة";
            public static string CannotDeleteProduct => "لا يمكن حذف المنتج";
            public static string CannotDeleteCategory => "لا يمكن حذف الفئة";
            public static string CannotDeleteBrand => "لا يمكن حذف العلامة التجارية";
            public static string CannotDeleteUnit => "لا يمكن حذف الوحدة";
            public static string CannotDeleteWarehouse => "لا يمكن حذف المستودع";
            public static string CannotDeleteTax => "لا يمكن حذف الضريبة";
            public static string InsufficientStock => "مخزون غير كافي";
            public static string ErrorLoadingData => "خطأ في تحميل البيانات";
            public static string ErrorSavingData => "خطأ في حفظ البيانات";
            public static string ErrorDeletingData => "خطأ في حذف البيانات";
            public static string NetworkError => "خطأ في الشبكة";
            public static string ServerError => "خطأ في الخادم";
        }
    }
}
