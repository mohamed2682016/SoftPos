// إصلاح مشكلة بدء Blazor المتكرر
(function() {
    'use strict';
    
    // حفظ الدالة الأصلية لبدء Blazor
    var originalBlazorStart = null;
    var blazorStartAttempts = 0;
    var maxStartAttempts = 1;
    
    // مراقبة تحميل Blazor
    var blazorWatcher = setInterval(function() {
        if (window.Blazor && window.Blazor.start) {
            // حفظ الدالة الأصلية إذا لم تكن محفوظة
            if (!originalBlazorStart) {
                originalBlazorStart = window.Blazor.start;
                
                // استبدال دالة البدء بدالة محمية
                window.Blazor.start = function() {
                    blazorStartAttempts++;
                    
                    if (blazorStartAttempts > maxStartAttempts) {
                        console.warn('تحذير: تم منع محاولة بدء Blazor المتكررة (المحاولة رقم ' + blazorStartAttempts + ')');
                        return Promise.resolve();
                    }
                    
                    console.log('بدء Blazor (المحاولة رقم ' + blazorStartAttempts + ')');
                    
                    try {
                        return originalBlazorStart.apply(this, arguments);
                    } catch (error) {
                        if (error.message && error.message.includes('already started')) {
                            console.warn('تحذير: Blazor مبدوء بالفعل - تم تجاهل الخطأ');
                            return Promise.resolve();
                        }
                        throw error;
                    }
                };
                
                console.log('✅ تم تطبيق حماية Blazor من البدء المتكرر');
            }
            
            clearInterval(blazorWatcher);
        }
    }, 100);
    
    // إيقاف المراقبة بعد 10 ثوان
    setTimeout(function() {
        clearInterval(blazorWatcher);
    }, 10000);
    
    // معالجة أخطاء Blazor المحددة
    window.addEventListener('error', function(event) {
        if (event.filename && event.filename.includes('blazor.webview.js')) {
            if (event.message && event.message.includes('already started')) {
                console.warn('تم اعتراض وتجاهل خطأ Blazor المتكرر');
                event.preventDefault();
                event.stopPropagation();
                return true;
            }
        }
        return false;
    }, true);
    
})();