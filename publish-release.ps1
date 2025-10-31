# ============================================
# SoftPos Release Publisher Script
# ============================================

param(
    [Parameter(Mandatory=$true)]
    [string]$Version,
    
    [Parameter(Mandatory=$false)]
    [string]$ReleaseNotes = "Bug fixes and improvements",
    
    [Parameter(Mandatory=$false)]
    [string]$ReleaseNotesAr = "إصلاح الأخطاء وتحسينات"
)

Write-Host "============================================" -ForegroundColor Cyan
Write-Host "   SoftPos Release Publisher v1.0" -ForegroundColor Cyan
Write-Host "============================================" -ForegroundColor Cyan
Write-Host ""

# التحقق من صيغة الإصدار
if ($Version -notmatch '^\d+\.\d+\.\d+$') {
    Write-Host "❌ خطأ: صيغة الإصدار غير صحيحة. استخدم: X.Y.Z (مثال: 1.0.1)" -ForegroundColor Red
    exit 1
}

Write-Host "📦 الإصدار: v$Version" -ForegroundColor Green
Write-Host ""

# الخطوة 1: تحديث رقم الإصدار في الكود
Write-Host "🔄 الخطوة 1: تحديث رقم الإصدار في الكود..." -ForegroundColor Yellow

$updateServicePath = "Services\UpdateService.cs"
if (Test-Path $updateServicePath) {
    $content = Get-Content $updateServicePath -Raw
    $content = $content -replace 'private const string CURRENT_VERSION = ".*?";', "private const string CURRENT_VERSION = `"$Version`";"
    Set-Content $updateServicePath $content
    Write-Host "✅ تم تحديث UpdateService.cs" -ForegroundColor Green
} else {
    Write-Host "⚠️  تحذير: لم يتم العثور على UpdateService.cs" -ForegroundColor Yellow
}

Write-Host ""

# الخطوة 2: Build المشروع
Write-Host "🔨 الخطوة 2: بناء المشروع..." -ForegroundColor Yellow

$outputFolder = "publish_v$Version"
$buildCommand = "dotnet publish -c Release -f net8.0-windows10.0.19041.0 -r win-x64 --self-contained true -p:PublishSingleFile=false -p:WindowsAppSDKSelfContained=true -p:WindowsPackageType=None -o `"$outputFolder`""

Write-Host "تنفيذ: $buildCommand" -ForegroundColor Gray
Invoke-Expression $buildCommand

if ($LASTEXITCODE -ne 0) {
    Write-Host "❌ فشل البناء!" -ForegroundColor Red
    exit 1
}

Write-Host "✅ تم البناء بنجاح" -ForegroundColor Green
Write-Host ""

# الخطوة 3: إنشاء ملف README
Write-Host "📝 الخطوة 3: إنشاء ملف README..." -ForegroundColor Yellow

$readmeContent = @"
═══════════════════════════════════════════════════════════════════
                    SoftPos v$Version
                         نسخة مستقلة بدون تثبيت
═══════════════════════════════════════════════════════════════════

📦 النسخة: v$Version
📅 التاريخ: $(Get-Date -Format "yyyy-MM-dd")
🖥️ النظام: Windows 10/11 (x64)

═══════════════════════════════════════════════════════════════════
                          🚀 طريقة التشغيل
═══════════════════════════════════════════════════════════════════

✅ لا يحتاج تثبيت .NET Runtime!
✅ جاهز للتشغيل مباشرة!

1️⃣ افتح المجلد
2️⃣ شغل الملف: SoftPos.exe
3️⃣ استمتع بالبرنامج! 🎉

═══════════════════════════════════════════════════════════════════
                          📋 ملاحظات الإصدار
═══════════════════════════════════════════════════════════════════

$ReleaseNotesAr

═══════════════════════════════════════════════════════════════════
"@

Set-Content "$outputFolder\README.txt" $readmeContent
Write-Host "✅ تم إنشاء README.txt" -ForegroundColor Green
Write-Host ""

# الخطوة 4: ضغط الملفات
Write-Host "📦 الخطوة 4: ضغط الملفات..." -ForegroundColor Yellow

$zipFileName = "SoftPos-v$Version.zip"
$zipPath = Join-Path (Get-Location) $zipFileName

if (Test-Path $zipPath) {
    Remove-Item $zipPath -Force
}

Compress-Archive -Path "$outputFolder\*" -DestinationPath $zipPath -CompressionLevel Optimal

if (Test-Path $zipPath) {
    $fileSize = [math]::Round((Get-Item $zipPath).Length / 1MB, 2)
    Write-Host "✅ تم إنشاء الملف: $zipFileName ($fileSize MB)" -ForegroundColor Green
} else {
    Write-Host "❌ فشل إنشاء ملف ZIP!" -ForegroundColor Red
    exit 1
}

Write-Host ""

# الخطوة 5: تحديث version.json
Write-Host "📝 الخطوة 5: تحديث version.json..." -ForegroundColor Yellow

$versionJson = @{
    Version = $Version
    ReleaseDate = Get-Date -Format "yyyy-MM-dd"
    DownloadUrl = "https://github.com/YOUR_USERNAME/SoftPos/releases/download/v$Version/SoftPos-v$Version.zip"
    FileSize = "$fileSize MB"
    ReleaseNotes = $ReleaseNotes
    ReleaseNotesAr = $ReleaseNotesAr
    Mandatory = $false
    MinVersion = "1.0.0"
} | ConvertTo-Json -Depth 10

Set-Content "version.json" $versionJson
Write-Host "✅ تم تحديث version.json" -ForegroundColor Green
Write-Host ""

# الخطوة 6: Git Commands
Write-Host "📤 الخطوة 6: أوامر Git..." -ForegroundColor Yellow
Write-Host ""
Write-Host "قم بتنفيذ الأوامر التالية:" -ForegroundColor Cyan
Write-Host ""
Write-Host "git add ." -ForegroundColor White
Write-Host "git commit -m `"Release v$Version`"" -ForegroundColor White
Write-Host "git tag v$Version" -ForegroundColor White
Write-Host "git push origin main" -ForegroundColor White
Write-Host "git push origin v$Version" -ForegroundColor White
Write-Host ""

# الخطوة 7: تعليمات GitHub Release
Write-Host "🌐 الخطوة 7: إنشاء Release على GitHub..." -ForegroundColor Yellow
Write-Host ""
Write-Host "1. اذهب إلى: https://github.com/YOUR_USERNAME/SoftPos/releases/new" -ForegroundColor Cyan
Write-Host "2. Tag version: v$Version" -ForegroundColor Cyan
Write-Host "3. Release title: SoftPos v$Version" -ForegroundColor Cyan
Write-Host "4. ارفع الملف: $zipFileName" -ForegroundColor Cyan
Write-Host "5. اضغط 'Publish release'" -ForegroundColor Cyan
Write-Host ""

# الخطوة 8: فتح المجلد
Write-Host "📂 الخطوة 8: فتح مجلد الملفات..." -ForegroundColor Yellow
Start-Process explorer.exe -ArgumentList "/select,`"$zipPath`""
Write-Host "✅ تم فتح المجلد" -ForegroundColor Green
Write-Host ""

# الملخص
Write-Host "============================================" -ForegroundColor Cyan
Write-Host "   ✅ اكتمل التحضير بنجاح!" -ForegroundColor Green
Write-Host "============================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "📦 الملف الجاهز: $zipFileName" -ForegroundColor Green
Write-Host "📝 version.json: محدث" -ForegroundColor Green
Write-Host "🔢 الإصدار: v$Version" -ForegroundColor Green
Write-Host ""
Write-Host "⏭️  الخطوات التالية:" -ForegroundColor Yellow
Write-Host "1. نفذ أوامر Git المذكورة أعلاه" -ForegroundColor White
Write-Host "2. أنشئ Release على GitHub" -ForegroundColor White
Write-Host "3. ارفع ملف ZIP" -ForegroundColor White
Write-Host "4. حدث رابط التحميل في version.json إذا لزم الأمر" -ForegroundColor White
Write-Host ""
Write-Host "🎉 شكراً لاستخدامك SoftPos Release Publisher!" -ForegroundColor Cyan
Write-Host ""
