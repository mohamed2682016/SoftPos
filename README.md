# 🏪 SoftPos - نظام نقاط البيع المتكامل

<div dir="rtl">

نظام نقاط بيع متكامل مبني على .NET MAUI Blazor يدعم اللغة العربية بالكامل

</div>

---

## 📋 المحتويات

- [نظرة عامة](#-نظرة-عامة)
- [المميزات](#-المميزات)
- [متطلبات التشغيل](#-متطلبات-التشغيل)
- [التثبيت](#-التثبيت)
- [التحديثات](#-التحديثات)
- [البناء من المصدر](#-البناء-من-المصدر)
- [المساهمة](#-المساهمة)
- [الترخيص](#-الترخيص)

---

## 🎯 نظرة عامة

**SoftPos** هو نظام نقاط بيع (POS) متكامل مصمم خصيصاً للأسواق العربية. يوفر واجهة سهلة الاستخدام مع دعم كامل للغة العربية وميزات متقدمة لإدارة المبيعات والمشتريات والمخزون.

### 🌟 لماذا SoftPos؟

- ✅ **مجاني ومفتوح المصدر**
- ✅ **دعم كامل للغة العربية**
- ✅ **واجهة حديثة وسهلة**
- ✅ **لا يحتاج اتصال بالإنترنت**
- ✅ **قاعدة بيانات محلية (SQLite)**
- ✅ **تحديثات تلقائية**

---

## ✨ المميزات

### 💰 نقاط البيع (POS)
- واجهة نقاط بيع سريعة وسهلة
- دعم الباركود والماسح الضوئي
- طرق دفع متعددة (نقدي، بطاقة، تحويل)
- طباعة الفواتير
- إدارة الخصومات والكوبونات

### 📦 إدارة المخزون
- تتبع المخزون في الوقت الفعلي
- تنبيهات نفاد المخزون
- إدارة المستودعات المتعددة
- تقارير المخزون التفصيلية

### 🛒 المبيعات والمشتريات
- فواتير المبيعات والمشتريات
- مرتجعات المبيعات والمشتريات
- إدارة العملاء والموردين
- تقارير المبيعات والمشتريات

### 💼 الحسابات
- دفتر الأستاذ العام
- ميزان المراجعة
- قائمة الدخل
- الميزانية العمومية
- إدارة المدفوعات والمقبوضات

### 📊 التقارير
- تقارير المبيعات اليومية
- تقارير المخزون
- تقارير الأرباح والخسائر
- تقارير العملاء والموردين
- تصدير التقارير (Excel, PDF)

### ⚙️ الإعدادات
- إدارة المستخدمين والصلاحيات
- إعدادات الشركة
- إعدادات الضرائب
- إعدادات الطباعة
- النسخ الاحتياطي والاستعادة

---

## 💻 متطلبات التشغيل

### الحد الأدنى
- **نظام التشغيل:** Windows 10 (1809+) أو Windows 11
- **المعالج:** Intel/AMD x64 (64-bit)
- **الذاكرة:** 4 GB RAM
- **المساحة:** 500 MB مساحة فارغة
- **الشاشة:** 1280x720 أو أعلى

### الموصى به
- **نظام التشغيل:** Windows 11
- **المعالج:** Intel Core i5 أو أعلى
- **الذاكرة:** 8 GB RAM
- **المساحة:** 1 GB مساحة فارغة
- **الشاشة:** 1920x1080 أو أعلى

---

## 📥 التثبيت

### النسخة Self-Contained (موصى بها)

1. **تحميل النسخة:**
   - اذهب إلى [Releases](https://github.com/YOUR_USERNAME/SoftPos/releases)
   - حمل آخر نسخة: `SoftPos-vX.X.X.zip`

2. **فك الضغط:**
   - فك ضغط الملف في أي مكان تريده
   - مثال: `C:\SoftPos\`

3. **التشغيل:**
   - افتح المجلد
   - شغل `SoftPos.exe`
   - استمتع! 🎉

> **ملاحظة:** النسخة Self-Contained لا تحتاج تثبيت .NET Runtime!

---

## 🔄 التحديثات

### التحديث التلقائي

البرنامج يحتوي على نظام تحديث تلقائي:

1. عند توفر تحديث جديد، سيظهر إشعار
2. اضغط "تحميل التحديث"
3. انتظر حتى يكتمل التحميل
4. فك ضغط الملف الجديد
5. شغل النسخة الجديدة

### التحديث اليدوي

1. اذهب إلى [Releases](https://github.com/YOUR_USERNAME/SoftPos/releases)
2. حمل آخر نسخة
3. فك الضغط واستبدل الملفات القديمة

---

## 🛠️ البناء من المصدر

### المتطلبات
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) أو [VS Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

### خطوات البناء

```bash
# 1. استنساخ المشروع
git clone https://github.com/YOUR_USERNAME/SoftPos.git
cd SoftPos

# 2. استعادة الحزم
dotnet restore

# 3. البناء
dotnet build -c Release

# 4. التشغيل
dotnet run

# 5. النشر (Self-Contained)
dotnet publish -c Release -f net8.0-windows10.0.19041.0 -r win-x64 --self-contained true -o publish
```

### استخدام السكريبت

```powershell
# إنشاء نسخة جاهزة للتوزيع
.\publish-release.ps1 -Version "1.0.1" -ReleaseNotesAr "إصلاح الأخطاء"
```

---

## 📚 التوثيق

- [دليل المستخدم](docs/USER_GUIDE.md) (قريباً)
- [دليل المطور](docs/DEVELOPER_GUIDE.md) (قريباً)
- [دليل رفع التحديثات](GITHUB_UPDATE_GUIDE.md)
- [دليل البدء السريع](QUICK_START_GITHUB.md)

---

## 🤝 المساهمة

نرحب بمساهماتكم! 🎉

### كيفية المساهمة

1. Fork المشروع
2. أنشئ branch جديد (`git checkout -b feature/amazing-feature`)
3. Commit التغييرات (`git commit -m 'Add amazing feature'`)
4. Push إلى Branch (`git push origin feature/amazing-feature`)
5. افتح Pull Request

### إرشادات المساهمة

- اكتب كود نظيف ومنظم
- أضف تعليقات واضحة
- اتبع معايير C# Coding Standards
- اختبر التغييرات قبل الـ PR
- اكتب وصف واضح للـ PR

---

## 🐛 الإبلاغ عن الأخطاء

وجدت خطأ؟ ساعدنا في إصلاحه!

1. تأكد من أن الخطأ لم يتم الإبلاغ عنه مسبقاً
2. افتح [Issue جديد](https://github.com/YOUR_USERNAME/SoftPos/issues/new)
3. اكتب وصف واضح للمشكلة
4. أضف خطوات إعادة إنتاج الخطأ
5. أضف لقطات شاشة إن أمكن

---

## 💡 طلب ميزة جديدة

عندك فكرة رائعة؟ شاركها معنا!

1. افتح [Issue جديد](https://github.com/YOUR_USERNAME/SoftPos/issues/new)
2. اختر "Feature Request"
3. اشرح الميزة المطلوبة
4. اشرح لماذا هذه الميزة مفيدة

---

## 📊 الإحصائيات

![GitHub release](https://img.shields.io/github/v/release/YOUR_USERNAME/SoftPos)
![GitHub downloads](https://img.shields.io/github/downloads/YOUR_USERNAME/SoftPos/total)
![GitHub stars](https://img.shields.io/github/stars/YOUR_USERNAME/SoftPos)
![GitHub forks](https://img.shields.io/github/forks/YOUR_USERNAME/SoftPos)
![GitHub issues](https://img.shields.io/github/issues/YOUR_USERNAME/SoftPos)
![GitHub license](https://img.shields.io/github/license/YOUR_USERNAME/SoftPos)

---

## 🛡️ الترخيص

هذا المشروع مرخص تحت [MIT License](LICENSE) - انظر ملف LICENSE للتفاصيل.

---

## 👥 الفريق

- **المطور الرئيسي:** [اسمك](https://github.com/YOUR_USERNAME)

---

## 🙏 شكر وتقدير

- [.NET MAUI](https://dotnet.microsoft.com/apps/maui) - إطار العمل
- [MudBlazor](https://mudblazor.com/) - مكتبة UI
- [SQLite](https://www.sqlite.org/) - قاعدة البيانات
- [EPPlus](https://epplussoftware.com/) - تصدير Excel

---

## 📞 التواصل

- **البريد الإلكتروني:** your.email@example.com
- **الموقع:** https://yourwebsite.com
- **Twitter:** [@YourTwitter](https://twitter.com/YourTwitter)

---

## 🌟 ادعمنا

إذا أعجبك المشروع، لا تنسى:
- ⭐ إعطاء نجمة للمشروع
- 🔄 مشاركة المشروع مع الآخرين
- 💰 دعم المشروع (إذا أردت)

---

<div align="center">

**صنع بـ ❤️ في مصر**

[الموقع](https://yourwebsite.com) • [التوثيق](docs/) • [الإصدارات](https://github.com/YOUR_USERNAME/SoftPos/releases)

</div>
