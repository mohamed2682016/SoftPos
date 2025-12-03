# 📤 الملفات المطلوب رفعها على GitHub

## ✅ الملفات اللي **لازم** تترفع

### 📁 الكود المصدري (Source Code)
```
✅ *.cs                    - كل ملفات C#
✅ *.razor                 - كل ملفات Razor
✅ *.xaml                  - ملفات XAML
✅ *.csproj                - ملف المشروع
✅ *.sln                   - ملف Solution
```

### 📁 المجلدات الأساسية
```
✅ Components/             - مكونات Blazor
✅ Data/                   - نماذج البيانات
✅ Services/               - الخدمات
✅ Utilities/              - الأدوات المساعدة
✅ wwwroot/                - الملفات الثابتة (CSS, JS, Images)
✅ Resources/              - الموارد (Icons, Fonts, etc.)
✅ Properties/             - خصائص المشروع
```

### 📁 ملفات الإعدادات
```
✅ appsettings.json        - الإعدادات العامة
✅ MauiProgram.cs          - نقطة البداية
✅ App.xaml                - ملف التطبيق
✅ App.xaml.cs             - كود التطبيق
```

### 📁 ملفات التوثيق
```
✅ README.md               - صفحة المشروع الرئيسية
✅ GITHUB_UPDATE_GUIDE.md  - دليل التحديثات
✅ QUICK_START_GITHUB.md   - الدليل السريع
✅ HOW_TO_PUBLISH.txt      - خطوات النشر
✅ LICENSE                 - الترخيص (إذا موجود)
```

### 📁 ملفات النظام
```
✅ .gitignore              - ملفات Git المتجاهلة
✅ version.json            - معلومات الإصدار
✅ publish-release.ps1     - سكريبت النشر
```

---

## ❌ الملفات اللي **لا تُرفع** (محمية بـ .gitignore)

### 🚫 مجلدات Build
```
❌ bin/                    - ملفات البناء
❌ obj/                    - ملفات مؤقتة
❌ Debug/                  - ملفات Debug
❌ Release/                - ملفات Release
❌ publish/                - مجلدات النشر
❌ publish_*/              - كل مجلدات النشر
```

### 🚫 ملفات مؤقتة
```
❌ *.user                  - إعدادات المستخدم
❌ *.suo                   - إعدادات Visual Studio
❌ .vs/                    - مجلد Visual Studio
❌ .vscode/                - إعدادات VS Code
```

### 🚫 قواعد البيانات
```
❌ *.db                    - قواعد بيانات SQLite
❌ *.db-shm                - ملفات SQLite المؤقتة
❌ *.db-wal                - ملفات SQLite المؤقتة
❌ *.sqlite                - قواعد بيانات
```

### 🚫 ملفات كبيرة
```
❌ *.zip                   - ملفات مضغوطة
❌ *.exe                   - ملفات تنفيذية
❌ *.dll                   - مكتبات (تُبنى تلقائياً)
```

### 🚫 ملفات حساسة
```
❌ appsettings.Development.json  - إعدادات التطوير
❌ appsettings.Local.json        - إعدادات محلية
❌ *.log                         - ملفات السجلات
```

---

## 📋 هيكل المشروع على GitHub

```
SoftPos/                          ✅ رفع
├── .gitignore                    ✅ رفع
├── README.md                     ✅ رفع
├── version.json                  ✅ رفع
├── publish-release.ps1           ✅ رفع
├── GITHUB_UPDATE_GUIDE.md        ✅ رفع
├── QUICK_START_GITHUB.md         ✅ رفع
├── HOW_TO_PUBLISH.txt            ✅ رفع
├── SoftPos.sln                   ✅ رفع
├── SoftPos.csproj                ✅ رفع
├── MauiProgram.cs                ✅ رفع
├── App.xaml                      ✅ رفع
├── App.xaml.cs                   ✅ رفع
├── appsettings.json              ✅ رفع
│
├── Components/                   ✅ رفع (كل المحتوى)
│   ├── Layout/
│   ├── Pages/
│   └── ...
│
├── Data/                         ✅ رفع (كل المحتوى)
│   ├── Account/
│   ├── Setting/
│   └── ...
│
├── Services/                     ✅ رفع (كل المحتوى)
│   ├── UpdateService.cs
│   ├── DatabaseService.cs
│   └── ...
│
├── Utilities/                    ✅ رفع (كل المحتوى)
│   └── ...
│
├── wwwroot/                      ✅ رفع (كل المحتوى)
│   ├── css/
│   ├── js/
│   ├── images/
│   └── ...
│
├── Resources/                    ✅ رفع (كل المحتوى)
│   ├── AppIcon/
│   ├── Fonts/
│   └── ...
│
├── Properties/                   ✅ رفع
│   └── launchSettings.json
│
├── bin/                          ❌ لا تُرفع
├── obj/                          ❌ لا تُرفع
├── publish/                      ❌ لا تُرفع
├── publish_*/                    ❌ لا تُرفع
├── .vs/                          ❌ لا تُرفع
├── *.db                          ❌ لا تُرفع
├── *.zip                         ❌ لا تُرفع
└── *.log                         ❌ لا تُرفع
```

---

## 🎯 الأوامر للرفع

### 1️⃣ أول مرة (Initial Upload)
```bash
# تهيئة Git
git init

# إضافة كل الملفات (سيتجاهل ما في .gitignore تلقائياً)
git add .

# Commit
git commit -m "Initial commit - SoftPos v1.0.0"

# ربط بـ GitHub
git remote add origin https://github.com/YOUR_USERNAME/SoftPos.git

# رفع
git branch -M main
git push -u origin main
```

### 2️⃣ التحديثات اللاحقة
```bash
# إضافة التغييرات
git add .

# Commit
git commit -m "وصف التغييرات"

# رفع
git push
```

---

## 🔍 التحقق من الملفات قبل الرفع

### عرض الملفات اللي هتترفع
```bash
git status
```

### عرض الملفات المتجاهلة
```bash
git status --ignored
```

### التأكد من .gitignore يعمل
```bash
# يجب ألا تظهر هذه المجلدات:
# bin/, obj/, publish/, .vs/
git status
```

---

## ⚠️ ملاحظات مهمة

### 1. حجم الملفات
- GitHub يسمح بملفات حتى **100 MB**
- إذا كان عندك ملف أكبر، استخدم **Git LFS**
- الملفات الكبيرة (ZIP, EXE) تُرفع في **Releases** فقط

### 2. الملفات الحساسة
```
❌ لا ترفع:
   - كلمات المرور
   - API Keys
   - Connection Strings حقيقية
   - بيانات العملاء
   - قواعد البيانات
```

### 3. البيانات الشخصية
```
❌ لا ترفع:
   - ملفات .db (قواعد البيانات)
   - ملفات .log (السجلات)
   - ملفات backup
   - بيانات الاختبار
```

---

## 📊 حجم Repository المتوقع

```
الكود المصدري:        ~50-100 MB
wwwroot (CSS/JS):      ~10-20 MB
Resources (Icons):     ~5-10 MB
─────────────────────────────────
الإجمالي:             ~65-130 MB
```

**ملاحظة:** الملفات المبنية (bin/obj) لا تُحسب لأنها متجاهلة!

---

## ✅ Checklist قبل الرفع

قبل ما ترفع على GitHub، تأكد من:

- [ ] ملف .gitignore موجود وصحيح
- [ ] لا توجد ملفات .db
- [ ] لا توجد ملفات .zip
- [ ] لا توجد مجلدات bin/ أو obj/
- [ ] لا توجد كلمات مرور في الكود
- [ ] README.md محدث
- [ ] version.json محدث
- [ ] استبدلت YOUR_USERNAME بحسابك الحقيقي

---

## 🆘 إذا رفعت ملف بالغلط

### حذف ملف من Git (لكن يبقى محلياً)
```bash
git rm --cached filename
git commit -m "Remove file from git"
git push
```

### حذف مجلد من Git
```bash
git rm -r --cached foldername/
git commit -m "Remove folder from git"
git push
```

### حذف ملف من التاريخ كله (خطير!)
```bash
# استخدم BFG Repo-Cleaner أو git filter-branch
# راجع: https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/removing-sensitive-data-from-a-repository
```

---

## 📞 روابط مفيدة

- [GitHub .gitignore Templates](https://github.com/github/gitignore)
- [Git Documentation](https://git-scm.com/doc)
- [GitHub Docs](https://docs.github.com/)

---

## 💡 نصيحة أخيرة

**قاعدة ذهبية:**
> إذا كان الملف يتغير عند كل Build أو يحتوي على بيانات شخصية، لا ترفعه!

الملفات اللي تُرفع هي **الكود المصدري فقط**، مش الملفات المبنية!

---

تم إنشاء هذا الدليل بواسطة Kiro 🤖
