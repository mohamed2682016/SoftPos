// معالج الأخطاء العام للتطبيق
(function() {
    'use strict';
    
    // منع إظهار أخطاء jQuery إذا لم تكن محملة
    window.addEventListener('error', function(event) {
        var errorMessage = event.message || '';
        
        // تجاهل أخطاء jQuery المعروفة
        if (errorMessage.includes('$ is not defined') || 
            errorMessage.includes('jQuery is not defined')) {
            console.warn('تحذير: jQuery غير محمل - سيتم تجاهل الميزات التي تعتمد عليه');
            event.preventDefault();
            return true;
        }
        
        // تجاهل أخطاء export/import في المتصفحات القديمة
        if (errorMessage.includes('Unexpected token') && 
            errorMessage.includes('export')) {
            console.warn('تحذير: المتصفح لا يدعم ES6 modules');
            event.preventDefault();
            return true;
        }
        
        // تجاهل أخطاء Blazor المتكررة
        if (errorMessage.includes('Blazor has already started') || 
            errorMessage.includes('blazor.webview.js')) {
            console.warn('تحذير: محاولة بدء Blazor أكثر من مرة - تم تجاهل الخطأ');
            event.preventDefault();
            return true;
        }
        
        return false;
    });
    
    // معالجة أخطاء Promise
    window.addEventListener('unhandledrejection', function(event) {
        var reason = event.reason || {};
        var message = reason.message || reason.toString();
        
        // تجاهل أخطاء Blazor المتكررة
        if (message.includes('Blazor has already started') || 
            message.includes('blazor.webview.js')) {
            console.warn('تحذير: محاولة بدء Blazor أكثر من مرة في Promise - تم تجاهل الخطأ');
            event.preventDefault();
            return;
        }
        
        console.error('خطأ Promise غير معالج:', reason);
    });
    
    // التحقق من تحميل المكتبات المطلوبة
    window.addEventListener('DOMContentLoaded', function() {
        setTimeout(function() {
            // التحقق من jQuery
            if (typeof $ === 'undefined') {
                console.warn('تحذير: jQuery غير محمل - بعض الميزات قد لا تعمل');
            }
            
            // التحقق من Bootstrap
            if (typeof bootstrap === 'undefined') {
                console.warn('تحذير: Bootstrap JS غير محمل');
            }
            
            // التحقق من Chart.js
            if (typeof Chart === 'undefined') {
                console.warn('تحذير: Chart.js غير محمل');
            }
            
            // التحقق من html2pdf
            if (typeof html2pdf === 'undefined') {
                console.warn('تحذير: html2pdf غير محمل');
            }
        }, 2000);
    });
    
})();