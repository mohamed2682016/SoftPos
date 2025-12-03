# 🚀 دليل رفع التحديثات على GitHub

## 📋 نظرة عامة

البرنامج يحتوي على نظام تحديث تلقائي يعتمد على:
1. ملف `version.json` على GitHub
2. ملف التحديث (ZIP) على GitHub Releases
3. `UpdateService.cs` في البرنامج للتحقق والتحميل

---

## 📁 الخطوة 1: إعداد Repository على GitHub

### 1.1 إنشاء Repository جديد
```bash
# على GitHub:
1. اذهب إلى https://github.com/new
2. اسم الـ Repo: SoftPos (أو أي اسم تريده)
3. اختر Public أو Private
4. اضغط Create Repository
```

### 1.2 رفع الكود الحالي
```bash
# في مجلد المشروع:
cd F:\SoftPos\SoftPos

# تهيئة Git (إذا لم يكن موجود)
git init

# إضافة الملفات
git add .

# Commit أول
git commit -m "Initial commit - SoftPos v1.0.0"

# ربط بـ GitHub
git remote add origin https://github.com/YOUR_USERNAME/SoftPos.git

# رفع الكود
git branch -M main
git push -u origin main
```

---

## 📝 الخطوة 2: إنشاء ملف version.json

### 2.1 إنشاء الملف في الـ Repository
```json
{
  "Version": "1.0.1",
  "ReleaseDate": "2025-10-30",
  "DownloadUrl": "https://github.com/YOUR_USERNAME/SoftPos/releases/download/v1.0.1/SoftPos-v1.0.1.zip",
  "FileSize": "450 MB",
  "ReleaseNotes": "- Bug fixes\n- Performance improvements\n- New features added",
  "ReleaseNotesAr": "- إصلاح الأخطاء\n- تحسينات في الأداء\n- إضافة ميزات جديدة",
  "Mandatory": false,
  "MinVersion": "1.0.0"
}
```

### 2.2 رفع الملف على GitHub
```bash
# إنشاء الملف
echo '{"Version":"1.0.1",...}' > version.json

# إضافة وحفظ
git add version.json
git commit -m "Add version.json for update system"
git push
```

---

## 📦 الخطوة 3: إنشاء Release على GitHub

### 3.1 تجهيز ملف التحديث
```bash
# 1. اضغط مجلد publish_standalone_final كـ ZIP
# في Windows:
# - اضغط كليك يمين على المجلد
# - اختر "Send to" > "Compressed (zipped) folder"
# - سمي الملف: SoftPos-v1.0.1.zip
```

### 3.2 إنشاء Release على GitHub
```
1. اذهب إلى: https://github.com/YOUR_USERNAME/SoftPos/releases
2. اضغط "Create a new release"
3. املأ البيانات:
   - Tag version: v1.0.1
   - Release title: SoftPos v1.0.1
   - Description: 
     ```
     ## 🎉 SoftPos v1.0.1
     
     ### ✨ New Features
     - Feature 1
     - Feature 2
     
     ### 🐛 Bug Fixes
     - Fix 1
     - Fix 2
     
     ### 📥 Download
     Download the ZIP file below and extract it.
     ```
4. ارفع ملف SoftPos-v1.0.1.zip في قسم "Attach binaries"
5. اضغط "Publish release"
```

---

## 🔄 الخطوة 4: تحديث رابط التحميل

### 4.1 نسخ رابط التحميل
بعد نشر الـ Release، الرابط سيكون:
```
https://github.com/YOUR_USERNAME/SoftPos/releases/download/v1.0.1/SoftPos-v1.0.1.zip
```

### 4.2 تحديث version.json
```json
{
  "Version": "1.0.1",
  "ReleaseDate": "2025-10-30",
  "DownloadUrl": "https://github.com/YOUR_USERNAME/SoftPos/releases/download/v1.0.1/SoftPos-v1.0.1.zip",
  "FileSize": "450 MB",
  "ReleaseNotes": "- Bug fixes\n- Performance improvements",
  "ReleaseNotesAr": "- إصلاح الأخطاء\n- تحسينات في الأداء",
  "Mandatory": false,
  "MinVersion": "1.0.0"
}
```

```bash
# حفظ التغييرات
git add version.json
git commit -m "Update version.json to v1.0.1"
git push
```

---

## 🎯 الخطوة 5: تحديث الكود في البرنامج

### 5.1 تحديث UpdateService.cs
```csharp
// في Services/UpdateService.cs
private const string VERSION_URL = "https://raw.githubusercontent.com/YOUR_USERNAME/SoftPos/main/version.json";
private const string CURRENT_VERSION = "1.0.0"; // النسخة الحالية
```

### 5.2 إضافة صفحة التحديثات (إذا لم تكن موجودة)
```razor
@page "/updates"
@inject UpdateService UpdateService

<MudContainer>
    <MudText Typo="Typo.h4">التحديثات</MudText>
    
    @if (updateAvailable)
    {
        <MudAlert Severity="Severity.Info">
            تحديث جديد متاح: @updateInfo?.Version
        </MudAlert>
        
        <MudButton OnClick="DownloadUpdate" Color="Color.Primary">
            تحميل التحديث
        </MudButton>
    }
    else
    {
        <MudText>أنت تستخدم أحدث نسخة</MudText>
    }
</MudContainer>

@code {
    private bool updateAvailable = false;
    private UpdateInfo? updateInfo;
    
    protected override async Task OnInitializedAsync()
    {
        updateInfo = await UpdateService.CheckForUpdates();
        updateAvailable = updateInfo != null;
    }
    
    private async Task DownloadUpdate()
    {
        // تنفيذ التحميل
    }
}
```

---

## 🔁 عملية التحديث الكاملة (خطوة بخطوة)

### عند إصدار تحديث جديد:

#### 1️⃣ تحديث رقم الإصدار في الكود
```csharp
// في UpdateService.cs
private const string CURRENT_VERSION = "1.0.1"; // النسخة الجديدة
```

#### 2️⃣ Build النسخة الجديدة
```bash
dotnet publish -c Release -f net8.0-windows10.0.19041.0 -r win-x64 --self-contained true -o "publish_v1.0.1"
```

#### 3️⃣ ضغط الملفات
```
- اضغط مجلد publish_v1.0.1 كـ ZIP
- سمي الملف: SoftPos-v1.0.1.zip
```

#### 4️⃣ إنشاء Release على GitHub
```
1. اذهب إلى Releases
2. Create new release
3. Tag: v1.0.1
4. ارفع ملف ZIP
5. Publish
```

#### 5️⃣ تحديث version.json
```json
{
  "Version": "1.0.1",
  "DownloadUrl": "https://github.com/YOUR_USERNAME/SoftPos/releases/download/v1.0.1/SoftPos-v1.0.1.zip",
  ...
}
```

#### 6️⃣ Push التغييرات
```bash
git add version.json
git commit -m "Release v1.0.1"
git push
```

---

## 🧪 اختبار نظام التحديث

### 1. اختبار محلي
```csharp
// في UpdateService.cs - للاختبار فقط
private const string CURRENT_VERSION = "0.9.0"; // نسخة قديمة للاختبار
```

### 2. تشغيل البرنامج
- شغل البرنامج
- اذهب لصفحة التحديثات
- يجب أن يظهر تنبيه بوجود تحديث

### 3. اختبار التحميل
- اضغط "تحميل التحديث"
- تأكد من التحميل بنجاح

---

## 📊 مثال كامل لـ version.json

```json
{
  "Version": "1.0.1",
  "ReleaseDate": "2025-10-30",
  "DownloadUrl": "https://github.com/mohamed2682016/SoftPos/releases/download/v1.0.1/SoftPos-v1.0.1.zip",
  "FileSize": "450 MB",
  "ReleaseNotes": "## What's New\n\n### Features\n- Added new POS interface\n- Improved performance\n- Added Arabic support\n\n### Bug Fixes\n- Fixed database connection issues\n- Fixed printing problems\n- Fixed UI glitches",
  "ReleaseNotesAr": "## الجديد في هذا الإصدار\n\n### المميزات\n- إضافة واجهة نقاط البيع الجديدة\n- تحسين الأداء\n- إضافة دعم اللغة العربية\n\n### إصلاح الأخطاء\n- إصلاح مشاكل الاتصال بقاعدة البيانات\n- إصلاح مشاكل الطباعة\n- إصلاح مشاكل الواجهة",
  "Mandatory": false,
  "MinVersion": "1.0.0"
}
```

---

## 🔐 نصائح أمنية

### 1. استخدام GitHub Tokens
```bash
# للـ Private Repositories
# أضف Token في الـ Headers
client.DefaultRequestHeaders.Add("Authorization", "token YOUR_GITHUB_TOKEN");
```

### 2. التحقق من التوقيع
```csharp
// يمكن إضافة Hash للملف للتحقق من سلامته
public string FileHash { get; set; } = string.Empty;
```

---

## 📱 إشعارات التحديث

### إضافة فحص تلقائي عند بدء التشغيل
```csharp
// في App.xaml.cs أو MainPage
protected override async void OnStart()
{
    base.OnStart();
    
    var updateService = new UpdateService();
    var update = await updateService.CheckForUpdates();
    
    if (update != null)
    {
        // عرض إشعار
        await DisplayAlert("تحديث متاح", 
            $"النسخة {update.Version} متاحة الآن!", 
            "تحميل", "لاحقاً");
    }
}
```

---

## 🎨 واجهة التحديث المقترحة

```razor
<MudDialog>
    <DialogContent>
        <MudText Typo="Typo.h6">تحديث جديد متاح! 🎉</MudText>
        <MudText>النسخة: @updateInfo.Version</MudText>
        <MudText>التاريخ: @updateInfo.ReleaseDate</MudText>
        <MudText>الحجم: @updateInfo.FileSize</MudText>
        
        <MudDivider Class="my-4" />
        
        <MudText Typo="Typo.subtitle1">ملاحظات الإصدار:</MudText>
        <MudText>@updateInfo.ReleaseNotesAr</MudText>
        
        @if (downloading)
        {
            <MudProgressLinear Value="@downloadProgress" Color="Color.Primary" />
            <MudText>جاري التحميل: @downloadProgress.ToString("F1")%</MudText>
        }
    </DialogContent>
    <DialogActions>
        <MudButton OnClick="Cancel">لاحقاً</MudButton>
        <MudButton Color="Color.Primary" OnClick="Download">تحميل الآن</MudButton>
    </DialogActions>
</MudDialog>
```

---

## 🚨 استكشاف الأخطاء

### المشكلة: لا يتم اكتشاف التحديث
**الحل:**
1. تأكد من رابط version.json صحيح
2. تأكد من الملف موجود على GitHub
3. تأكد من رقم الإصدار في version.json أكبر من CURRENT_VERSION

### المشكلة: فشل التحميل
**الحل:**
1. تأكد من رابط التحميل صحيح
2. تأكد من الملف موجود في Release
3. تأكد من الاتصال بالإنترنت

### المشكلة: 404 Error
**الحل:**
1. تأكد من اسم الـ Repository صحيح
2. تأكد من اسم الملف في Release صحيح
3. تأكد من الـ Tag صحيح (v1.0.1)

---

## 📚 موارد إضافية

- [GitHub Releases Documentation](https://docs.github.com/en/repositories/releasing-projects-on-github)
- [GitHub API for Releases](https://docs.github.com/en/rest/releases)
- [Semantic Versioning](https://semver.org/)

---

## ✅ Checklist للتحديث

- [ ] تحديث CURRENT_VERSION في الكود
- [ ] Build النسخة الجديدة
- [ ] ضغط الملفات كـ ZIP
- [ ] إنشاء Release على GitHub
- [ ] رفع ملف ZIP
- [ ] تحديث version.json
- [ ] Push التغييرات
- [ ] اختبار التحديث
- [ ] إعلام المستخدمين

---

## 🎯 الخلاصة

نظام التحديث يعمل كالتالي:
1. البرنامج يفحص version.json على GitHub
2. إذا كان هناك نسخة أحدث، يعرض إشعار
3. المستخدم يضغط "تحميل"
4. البرنامج يحمل الملف من GitHub Releases
5. المستخدم يفك الضغط ويشغل النسخة الجديدة

**ملاحظة:** يمكن تطوير النظام ليقوم بالتحديث التلقائي بالكامل!

---

تم إنشاء هذا الدليل بواسطة Kiro 🤖
