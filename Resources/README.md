# ملفات الترجمة - Translation Files

هذا المجلد يحتوي على ملفات الترجمة الشاملة لمشروع QuickproPos. تم تنظيم الملفات بطريقة منطقية لتسهيل الاستخدام والصيانة.

## هيكل الملفات - File Structure

### 1. الملفات الأساسية - Core Files
- `CommonTranslations.cs` - الترجمات الشائعة المستخدمة في معظم الصفحات
- `MessageTranslations.cs` - ترجمات الرسائل والتنبيهات
- `PageTranslations.cs` - ترجمات صفحات التطبيق
- `Localization.cs` - ترجمات التنقل والقوائم

### 2. ملفات الترجمة المتخصصة - Specialized Translation Files
- `PosTranslations.cs` - ترجمات صفحة نقطة البيع (POS)
- `SalesTranslations.cs` - ترجمات صفحات المبيعات
- `PurchaseTranslations.cs` - ترجمات صفحات المشتريات
- `InventoryTranslations.cs` - ترجمات صفحات إدارة المخزون
- `ReportsTranslations.cs` - ترجمات صفحات التقارير
- `AuthTranslations.cs` - ترجمات صفحات المصادقة
- `UtilitiesTranslations.cs` - ترجمات صفحات الأدوات
- `DashboardTranslations.cs` - ترجمات لوحة التحكم

### 3. ملفات الترجمة الشاملة - Comprehensive Translation Files
- `AllTranslations.cs` - ملف ترجمة شامل يجمع كل الترجمات
- `QuickTranslations.cs` - ترجمات سريعة للاستخدام المباشر

## كيفية الاستخدام - How to Use

### 1. الاستخدام الأساسي - Basic Usage
```csharp
@using QuickproPos.Resources

// استخدام الترجمات الشائعة
<h1>@CommonTranslations.Dashboard</h1>
<button>@CommonTranslations.Save</button>
<span>@CommonTranslations.Loading</span>
```

### 2. الاستخدام المتخصص - Specialized Usage
```csharp
@using QuickproPos.Resources

// استخدام ترجمات نقطة البيع
<h1>@PosTranslations.Title</h1>
<button>@PosTranslations.Cash</button>
<span>@PosTranslations.ChooseCustomer</span>

// استخدام ترجمات المبيعات
<h1>@SalesTranslations.SalesInvoiceList.Title</h1>
<button>@SalesTranslations.SalesInvoiceList.Create</button>
```

### 3. الاستخدام السريع - Quick Usage
```csharp
@using QuickproPos.Resources

// استخدام الترجمات السريعة
<h1>@QuickTranslations.Dashboard</h1>
<button>@QuickTranslations.Save</button>
<span>@QuickTranslations.Loading</span>
```

### 4. الاستخدام الشامل - Comprehensive Usage
```csharp
@using QuickproPos.Resources

// استخدام الترجمات الشاملة
<h1>@AllTranslations.Dashboard.Title</h1>
<button>@AllTranslations.Common.Save</button>
<span>@AllTranslations.POS.ChooseCustomer</span>
```

## أمثلة على الاستخدام - Usage Examples

### 1. صفحة نقطة البيع - POS Page
```csharp
@page "/pos"
@using QuickproPos.Resources

<div class="pos-header">
    <h1>@PosTranslations.Title</h1>
    <div class="customer-section">
        <label>@PosTranslations.ChooseCustomer</label>
        <select>
            <option>@PosTranslations.ChooseCustomer</option>
        </select>
    </div>
    <div class="product-search">
        <input placeholder="@PosTranslations.ScanSearchProduct" />
    </div>
</div>

<div class="cart-section">
    <h3>@PosTranslations.Item</h3>
    <table>
        <thead>
            <tr>
                <th>@PosTranslations.Item</th>
                <th>@PosTranslations.Qty</th>
                <th>@PosTranslations.Rate</th>
                <th>@PosTranslations.DiscountPercent</th>
                <th>@PosTranslations.Actions</th>
            </tr>
        </thead>
    </table>
</div>

<div class="payment-section">
    <button class="btn btn-success">@PosTranslations.Cash</button>
    <button class="btn btn-primary">@PosTranslations.Card</button>
    <button class="btn btn-warning">@PosTranslations.UPI</button>
</div>
```

### 2. صفحة المبيعات - Sales Page
```csharp
@page "/sales"
@using QuickproPos.Resources

<div class="sales-header">
    <h1>@SalesTranslations.SalesInvoiceList.Title</h1>
    <a class="btn btn-primary" href="/sales/add">
        <i class="fas fa-plus"></i> @SalesTranslations.SalesInvoiceList.Create
    </a>
</div>

<div class="filters">
    <div class="form-group">
        <label>@SalesTranslations.SalesInvoiceList.FromDate</label>
        <InputDate @bind-Value="fromDate" />
    </div>
    <div class="form-group">
        <label>@SalesTranslations.SalesInvoiceList.ToDate</label>
        <InputDate @bind-Value="toDate" />
    </div>
    <div class="form-group">
        <label>@SalesTranslations.SalesInvoiceList.Customer</label>
        <select>
            <option value="0">@SalesTranslations.SalesInvoiceList.Choose</option>
        </select>
    </div>
    <button class="btn btn-primary" @onclick="LoadData">
        <i class="fas fa-search"></i> @SalesTranslations.SalesInvoiceList.Search
    </button>
</div>
```

### 3. صفحة المخزون - Inventory Page
```csharp
@page "/product"
@using QuickproPos.Resources

<div class="product-header">
    <h1>@InventoryTranslations.Product.Title</h1>
    <a class="btn btn-primary" href="/product/add">
        <i class="fas fa-plus"></i> @InventoryTranslations.Product.Create
    </a>
</div>

<div class="product-filters">
    <input placeholder="@InventoryTranslations.Product.Search" />
    <select>
        <option value="0">@InventoryTranslations.Product.Filter</option>
    </select>
</div>

<div class="product-table">
    <table>
        <thead>
            <tr>
                <th>@InventoryTranslations.Product.ProductName</th>
                <th>@InventoryTranslations.Product.ProductCode</th>
                <th>@InventoryTranslations.Product.Category</th>
                <th>@InventoryTranslations.Product.Brand</th>
                <th>@InventoryTranslations.Product.SalesRate</th>
                <th>@InventoryTranslations.Product.CurrentStock</th>
                <th>@InventoryTranslations.Product.Actions</th>
            </tr>
        </thead>
    </table>
</div>
```

## إضافة ترجمات جديدة - Adding New Translations

### 1. إضافة ترجمة جديدة إلى ملف موجود - Adding to Existing File
```csharp
// في ملف PosTranslations.cs
public static class PosTranslations
{
    // ترجمات موجودة...
    
    // إضافة ترجمة جديدة
    public static string NewFeature => "ميزة جديدة";
    public static string NewButton => "زر جديد";
}
```

### 2. إنشاء ملف ترجمة جديد - Creating New Translation File
```csharp
// إنشاء ملف جديد NewModuleTranslations.cs
namespace QuickproPos.Resources
{
    public static class NewModuleTranslations
    {
        public static string Title => "عنوان الوحدة الجديدة";
        public static string Description => "وصف الوحدة الجديدة";
        
        public static class SubModule
        {
            public static string Title => "عنوان الوحدة الفرعية";
            public static string Action => "إجراء";
        }
    }
}
```

## أفضل الممارسات - Best Practices

### 1. تنظيم الترجمات - Organizing Translations
- استخدم أسماء واضحة ومفهومة للفئات والخصائص
- نظم الترجمات حسب الوظيفة أو الصفحة
- استخدم التعليقات لتوضيح الغرض من كل مجموعة ترجمات

### 2. تسمية الترجمات - Naming Translations
- استخدم أسماء باللغة الإنجليزية للخصائص
- استخدم أسماء وصفية واضحة
- تجنب الاختصارات غير الواضحة

### 3. صيانة الترجمات - Maintaining Translations
- راجع الترجمات بانتظام للتأكد من دقتها
- أضف ترجمات جديدة عند الحاجة
- احذف الترجمات غير المستخدمة

### 4. اختبار الترجمات - Testing Translations
- اختبر الترجمات في بيئة التطوير
- تأكد من ظهور النصوص باللغة العربية بشكل صحيح
- اختبر الترجمات على أجهزة مختلفة

## ملاحظات مهمة - Important Notes

1. **التشفير**: تأكد من أن الملفات محفوظة بتشفير UTF-8
2. **الترتيب**: استخدم ترتيب منطقي للترجمات داخل كل فئة
3. **التوثيق**: أضف تعليقات توضيحية للترجمات المعقدة
4. **المراجعة**: راجع الترجمات مع متحدثي اللغة العربية الأصليين
5. **الاختبار**: اختبر الترجمات في بيئة حقيقية

## الدعم والمساعدة - Support and Help

إذا كنت بحاجة إلى مساعدة في استخدام ملفات الترجمة أو إضافة ترجمات جديدة، يرجى التواصل مع فريق التطوير.

---

**ملاحظة**: هذا الملف تم إنشاؤه تلقائياً ويجب تحديثه عند إضافة ترجمات جديدة أو تعديل الترجمات الموجودة.

