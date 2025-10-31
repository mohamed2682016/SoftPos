# Script to update version and push to GitHub
# استخدم هذا السكريبت لتحديث الإصدار ورفعه على GitHub

Write-Host "🔄 Updating version and pushing to GitHub..." -ForegroundColor Cyan

# Add all changes
git add .

# Commit with version message
git commit -m "Update to version 1.0.2"

# Push to GitHub
git push

Write-Host "✅ Version updated and pushed successfully!" -ForegroundColor Green
Write-Host ""
Write-Host "📋 Next steps:" -ForegroundColor Yellow
Write-Host "1. Go to: https://github.com/mohamed2682016/SoftPos/releases" -ForegroundColor White
Write-Host "2. Click 'Create a new release'" -ForegroundColor White
Write-Host "3. Tag: v1.0.2" -ForegroundColor White
Write-Host "4. Title: SoftPos v1.0.2" -ForegroundColor White
Write-Host "5. Upload the .exe file from publish_standalone_final folder" -ForegroundColor White
Write-Host "6. Click 'Publish release'" -ForegroundColor White
