# ============================================
# SoftPos - File Check Script
# يعرض الملفات اللي هتترفع على GitHub
# ============================================

Write-Host "═══════════════════════════════════════════════════════════════════" -ForegroundColor Cyan
Write-Host "              فحص الملفات قبل الرفع على GitHub" -ForegroundColor Cyan
Write-Host "═══════════════════════════════════════════════════════════════════" -ForegroundColor Cyan
Write-Host ""

# التحقق من وجود Git
if (-not (Get-Command git -ErrorAction SilentlyContinue)) {
    Write-Host "❌ Git غير مثبت! يرجى تثبيت Git أولاً." -ForegroundColor Red
    exit 1
}

# التحقق من وجود .gitignore
if (-not (Test-Path ".gitignore")) {
    Write-Host "⚠️  تحذير: ملف .gitignore غير موجود!" -ForegroundColor Yellow
    Write-Host "   يُنصح بإنشاء ملف .gitignore قبل الرفع." -ForegroundColor Yellow
    Write-Host ""
}

# عرض حالة Git
Write-Host "📊 حالة Git:" -ForegroundColor Yellow
Write-Host ""

# التحقق من تهيئة Git
if (-not (Test-Path ".git")) {
    Write-Host "⚠️  Git غير مهيأ في هذا المجلد" -ForegroundColor Yellow
    Write-Host "   لتهيئة Git، نفذ: git init" -ForegroundColor Gray
    Write-Host ""
} else {
    Write-Host "✅ Git مهيأ" -ForegroundColor Green
    Write-Host ""
}

# عرض الملفات اللي هتترفع
Write-Host "📁 الملفات اللي هتترفع على GitHub:" -ForegroundColor Yellow
Write-Host "─────────────────────────────────────────────────────────────────" -ForegroundColor Gray

if (Test-Path ".git") {
    $files = git ls-files
    if ($files) {
        $fileCount = ($files | Measure-Object).Count
        Write-Host "✅ عدد الملفات: $fileCount" -ForegroundColor Green
        Write-Host ""
        
        # تجميع حسب النوع
        $csFiles = $files | Where-Object { $_ -like "*.cs" }
        $razorFiles = $files | Where-Object { $_ -like "*.razor" }
        $jsonFiles = $files | Where-Object { $_ -like "*.json" }
        $mdFiles = $files | Where-Object { $_ -like "*.md" }
        
        Write-Host "📊 إحصائيات:" -ForegroundColor Cyan
        Write-Host "   ملفات C#:     $($csFiles.Count)" -ForegroundColor White
        Write-Host "   ملفات Razor:  $($razorFiles.Count)" -ForegroundColor White
        Write-Host "   ملفات JSON:   $($jsonFiles.Count)" -ForegroundColor White
        Write-Host "   ملفات MD:     $($mdFiles.Count)" -ForegroundColor White
        Write-Host ""
    } else {
        Write-Host "⚠️  لا توجد ملفات مضافة بعد" -ForegroundColor Yellow
        Write-Host "   لإضافة الملفات، نفذ: git add ." -ForegroundColor Gray
        Write-Host ""
    }
} else {
    Write-Host "⚠️  Git غير مهيأ - لا يمكن عرض الملفات" -ForegroundColor Yellow
    Write-Host ""
}

# عرض الملفات المتغيرة (غير محفوظة)
Write-Host "📝 الملفات المتغيرة (غير محفوظة):" -ForegroundColor Yellow
Write-Host "─────────────────────────────────────────────────────────────────" -ForegroundColor Gray

if (Test-Path ".git") {
    $status = git status --short
    if ($status) {
        $status | ForEach-Object {
            if ($_ -match "^\?\?") {
                Write-Host "  🆕 $_" -ForegroundColor Green
            } elseif ($_ -match "^M") {
                Write-Host "  ✏️  $_" -ForegroundColor Yellow
            } elseif ($_ -match "^D") {
                Write-Host "  🗑️  $_" -ForegroundColor Red
            } else {
                Write-Host "  $_" -ForegroundColor White
            }
        }
        Write-Host ""
    } else {
        Write-Host "✅ لا توجد تغييرات" -ForegroundColor Green
        Write-Host ""
    }
}

# عرض الملفات المتجاهلة (أمثلة)
Write-Host "🚫 أمثلة على الملفات المتجاهلة:" -ForegroundColor Yellow
Write-Host "─────────────────────────────────────────────────────────────────" -ForegroundColor Gray

$ignoredExamples = @(
    "bin/",
    "obj/",
    "publish/",
    "publish_*/",
    ".vs/",
    "*.db",
    "*.zip",
    "*.log"
)

foreach ($item in $ignoredExamples) {
    if (Test-Path $item.Replace("*", "")) {
        Write-Host "  ✅ $item (موجود ومتجاهل)" -ForegroundColor Green
    } else {
        Write-Host "  ⚪ $item (غير موجود)" -ForegroundColor Gray
    }
}
Write-Host ""

# فحص الملفات الكبيرة
Write-Host "📦 فحص الملفات الكبيرة (أكبر من 10 MB):" -ForegroundColor Yellow
Write-Host "─────────────────────────────────────────────────────────────────" -ForegroundColor Gray

$largeFiles = Get-ChildItem -Recurse -File | Where-Object { 
    $_.Length -gt 10MB -and 
    $_.FullName -notmatch "\\bin\\" -and 
    $_.FullName -notmatch "\\obj\\" -and
    $_.FullName -notmatch "\\publish" -and
    $_.FullName -notmatch "\\.vs\\"
}

if ($largeFiles) {
    foreach ($file in $largeFiles) {
        $sizeMB = [math]::Round($file.Length / 1MB, 2)
        Write-Host "  ⚠️  $($file.Name) - $sizeMB MB" -ForegroundColor Yellow
    }
    Write-Host ""
    Write-Host "  ⚠️  تحذير: GitHub يسمح بملفات حتى 100 MB فقط!" -ForegroundColor Yellow
} else {
    Write-Host "  ✅ لا توجد ملفات كبيرة" -ForegroundColor Green
}
Write-Host ""

# فحص الملفات الحساسة
Write-Host "🔒 فحص الملفات الحساسة:" -ForegroundColor Yellow
Write-Host "─────────────────────────────────────────────────────────────────" -ForegroundColor Gray

$sensitivePatterns = @(
    "*.db",
    "*.sqlite",
    "*.log",
    "*password*",
    "*secret*",
    "appsettings.Development.json",
    "appsettings.Local.json"
)

$foundSensitive = $false
foreach ($pattern in $sensitivePatterns) {
    $files = Get-ChildItem -Recurse -Filter $pattern -File -ErrorAction SilentlyContinue | Where-Object {
        $_.FullName -notmatch "\\bin\\" -and 
        $_.FullName -notmatch "\\obj\\" -and
        $_.FullName -notmatch "\\publish"
    }
    
    if ($files) {
        $foundSensitive = $true
        foreach ($file in $files) {
            Write-Host "  ⚠️  $($file.FullName)" -ForegroundColor Red
        }
    }
}

if (-not $foundSensitive) {
    Write-Host "  ✅ لا توجد ملفات حساسة" -ForegroundColor Green
} else {
    Write-Host ""
    Write-Host "  ⚠️  تأكد من أن هذه الملفات في .gitignore!" -ForegroundColor Yellow
}
Write-Host ""

# حساب الحجم الإجمالي
Write-Host "📊 الحجم الإجمالي للمشروع:" -ForegroundColor Yellow
Write-Host "─────────────────────────────────────────────────────────────────" -ForegroundColor Gray

$totalSize = (Get-ChildItem -Recurse -File | Where-Object {
    $_.FullName -notmatch "\\bin\\" -and 
    $_.FullName -notmatch "\\obj\\" -and
    $_.FullName -notmatch "\\publish" -and
    $_.FullName -notmatch "\\.vs\\" -and
    $_.FullName -notmatch "\\.git\\"
} | Measure-Object -Property Length -Sum).Sum

$totalSizeMB = [math]::Round($totalSize / 1MB, 2)

Write-Host "  📦 الحجم الكلي: $totalSizeMB MB" -ForegroundColor Cyan
Write-Host ""

if ($totalSizeMB -gt 100) {
    Write-Host "  ⚠️  تحذير: الحجم كبير! قد تحتاج لاستخدام Git LFS" -ForegroundColor Yellow
} elseif ($totalSizeMB -gt 50) {
    Write-Host "  ⚠️  الحجم متوسط - تأكد من عدم رفع ملفات غير ضرورية" -ForegroundColor Yellow
} else {
    Write-Host "  ✅ الحجم مناسب للرفع على GitHub" -ForegroundColor Green
}
Write-Host ""

# الخلاصة
Write-Host "═══════════════════════════════════════════════════════════════════" -ForegroundColor Cyan
Write-Host "                          📋 الخلاصة" -ForegroundColor Cyan
Write-Host "═══════════════════════════════════════════════════════════════════" -ForegroundColor Cyan
Write-Host ""

$issues = 0

if (-not (Test-Path ".gitignore")) {
    Write-Host "❌ ملف .gitignore غير موجود" -ForegroundColor Red
    $issues++
}

if ($largeFiles) {
    Write-Host "⚠️  توجد ملفات كبيرة" -ForegroundColor Yellow
    $issues++
}

if ($foundSensitive) {
    Write-Host "⚠️  توجد ملفات حساسة" -ForegroundColor Yellow
    $issues++
}

if ($issues -eq 0) {
    Write-Host "✅ كل شيء جاهز للرفع على GitHub!" -ForegroundColor Green
} else {
    Write-Host "⚠️  يُنصح بمراجعة المشاكل أعلاه قبل الرفع" -ForegroundColor Yellow
}

Write-Host ""
Write-Host "💡 الخطوات التالية:" -ForegroundColor Cyan
Write-Host "   1. راجع الملفات أعلاه" -ForegroundColor White
Write-Host "   2. تأكد من .gitignore صحيح" -ForegroundColor White
Write-Host "   3. نفذ: git add ." -ForegroundColor White
Write-Host "   4. نفذ: git commit -m 'Initial commit'" -ForegroundColor White
Write-Host "   5. نفذ: git push" -ForegroundColor White
Write-Host ""
Write-Host "═══════════════════════════════════════════════════════════════════" -ForegroundColor Cyan
