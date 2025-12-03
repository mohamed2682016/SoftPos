# 🚀 دليل سريع: رفع التحديث على GitHub

## ⚡ الطريقة السريعة (باستخدام السكريبت)

### 1️⃣ تشغيل السكريبت
```powershell
# في PowerShell
.\publish-release.ps1 -Version "1.0.1" -ReleaseNotesAr "إصلاح الأخطاء وتحسينات"
```

### 2️⃣ تنفيذ أوامر Git
```bash
git add .
git commit -m "Release v1.0.1"
git tag v1.0.1
git push origin main
git push origin v1.0.1
```

### 3️⃣ إنشاء Release على GitHub
1. اذهب إلى: https://github.com/YOUR_USERNAME/SoftPos/releases/new
2. اختر Tag: v1.0.1
3. ارفع ملف: SoftPos-v1.0.1.zip
4. اضغط "Publish release"

### 4️⃣ تحديث رابط التحميل (إذا لزم)
```bash
# عدل version.json وحدث الرابط
git add version.json
git commit -m "Update download URL"
git push
```

---

## 📝 الطريقة اليدوية

### الخطوة 1: تحديث الإصدار
```csharp
// في Services/UpdateService.cs
private const string CURRENT_VERSION = "1.0.1";
```

### الخطوة 2: Build
```bash
dotnet publish -c Release -f net8.0-windows10.0.19041.0 -r win-x64 --self-contained true -o "publish_v1.0.1"
```

### الخطوة 3: ضغط الملفات
- اضغط كليك يمين على مجلد `publish_v1.0.1`
- اختر "Send to" > "Compressed (zipped) folder"
- سمي الملف: `SoftPos-v1.0.1.zip`

### الخطوة 4: رفع على GitHub
```bash
# 1. Commit التغييرات
git add .
git commit -m "Release v1.0.1"

# 2. إنشاء Tag
git tag v1.0.1

# 3. Push
git push origin main
git push origin v1.0.1
```

### الخطوة 5: إنشاء Release
1. اذهب إلى GitHub Releases
2. "Create a new release"
3. اختر Tag: v1.0.1
4. ارفع ملف ZIP
5. "Publish release"

### الخطوة 6: تحديث version.json
```json
{
  "Version": "1.0.1",
  "DownloadUrl": "https://github.com/YOUR_USERNAME/SoftPos/releases/download/v1.0.1/SoftPos-v1.0.1.zip",
  ...
}
```

```bash
git add version.json
git commit -m "Update version.json"
git push
```

---

## 🎯 Checklist سريع

- [ ] حدث CURRENT_VERSION في الكود
- [ ] Build المشروع
- [ ] اضغط الملفات كـ ZIP
- [ ] Commit & Push
- [ ] أنشئ Tag
- [ ] أنشئ Release على GitHub
- [ ] ارفع ZIP
- [ ] حدث version.json
- [ ] Push version.json
- [ ] اختبر التحديث

---

## 🔧 أوامر مفيدة

### عرض الـ Tags
```bash
git tag
```

### حذف Tag (إذا أخطأت)
```bash
git tag -d v1.0.1
git push origin :refs/tags/v1.0.1
```

### عرض آخر Commits
```bash
git log --oneline -5
```

---

## 🆘 مشاكل شائعة

### المشكلة: "tag already exists"
```bash
# احذف الـ Tag القديم
git tag -d v1.0.1
git push origin :refs/tags/v1.0.1

# أنشئ Tag جديد
git tag v1.0.1
git push origin v1.0.1
```

### المشكلة: "file too large"
- GitHub يسمح بملفات حتى 2GB
- إذا كان الملف أكبر، استخدم Git LFS أو خدمة أخرى

### المشكلة: "404 Not Found" عند التحديث
- تأكد من رابط version.json صحيح
- تأكد من الملف موجود في main branch
- انتظر دقيقة (GitHub قد يحتاج وقت للتحديث)

---

## 📞 روابط مهمة

- **Repository:** https://github.com/YOUR_USERNAME/SoftPos
- **Releases:** https://github.com/YOUR_USERNAME/SoftPos/releases
- **version.json:** https://raw.githubusercontent.com/YOUR_USERNAME/SoftPos/main/version.json

---

## 💡 نصائح

1. **استخدم Semantic Versioning:**
   - Major.Minor.Patch (مثال: 1.0.1)
   - Major: تغييرات كبيرة
   - Minor: ميزات جديدة
   - Patch: إصلاح أخطاء

2. **اكتب Release Notes واضحة:**
   - ما الجديد؟
   - ما تم إصلاحه؟
   - أي تغييرات مهمة؟

3. **اختبر قبل النشر:**
   - جرب النسخة المضغوطة
   - تأكد من عمل البرنامج
   - اختبر على جهاز نظيف

4. **احتفظ بنسخة احتياطية:**
   - احتفظ بملفات ZIP القديمة
   - لا تحذف Releases القديمة فوراً

---

تم إنشاء هذا الدليل بواسطة Kiro 🤖
