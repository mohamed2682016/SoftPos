# مجلد الأصوات - Sounds Folder

## الغرض
هذا المجلد يحتوي على ملفات الصوت المستخدمة في نظام POS.

## الملفات المطلوبة

### success.mp3
صوت يتم تشغيله عند إضافة منتج بنجاح إلى الفاتورة.

## كيفية إضافة ملف الصوت

### الطريقة 1: استخدام ملف صوت جاهز
1. ابحث عن ملف صوت قصير (0.5-1 ثانية) بصيغة MP3
2. أعد تسميته إلى `success.mp3`
3. ضعه في هذا المجلد: `QuickproPos/wwwroot/sounds/`

### الطريقة 2: تحميل صوت مجاني من الإنترنت
يمكنك تحميل أصوات مجانية من:
- https://freesound.org/
- https://mixkit.co/free-sound-effects/
- https://www.zapsplat.com/

ابحث عن "beep" أو "notification" أو "success"

### الطريقة 3: إنشاء صوت بسيط
يمكنك استخدام أي برنامج تسجيل صوت أو مواقع مثل:
- https://www.beepbox.co/
- https://onlinetonegenerator.com/

## تخصيص الصوت

يمكنك تغيير مستوى الصوت من خلال تعديل الكود في `index.html`:

```javascript
audio.volume = 0.5; // قيمة من 0.0 إلى 1.0
```

## استخدام صوت مختلف

إذا أردت استخدام اسم ملف مختلف، قم بتعديل الكود في `PosPage.razor`:

```csharp
JSRuntime.InvokeVoidAsync("UpdateTodoList", "/sounds/your-sound-name.mp3");
```

## ملاحظات
- الصيغ المدعومة: MP3, WAV, OGG
- يُفضل استخدام ملفات صغيرة الحجم (أقل من 100KB)
- يُفضل أن تكون مدة الصوت قصيرة (0.5-1 ثانية)
