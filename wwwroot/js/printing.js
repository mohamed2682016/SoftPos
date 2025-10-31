// ملف الطباعة المخصص لـ QuickproPos

// دالة الطباعة الرئيسية
export function print(options) {
    try {
        console.log('Print function called with options:', options);
        
        // التحقق من وجود printJS
        if (typeof window.printJS !== 'undefined') {
            console.log('Using printJS library');
            
            // تحويل الخيارات إلى تنسيق printJS
            const printOptions = {
                printable: options.Printable || options.printable,
                type: (options.Type || options.type || 'html').toLowerCase(),
                showModal: options.ShowModal || options.showModal || false,
                modalMessage: options.ModalMessage || options.modalMessage || 'جاري تحضير الطباعة...',
                css: options.css,
                style: options.style,
                scanStyles: true,
                targetStyles: ['*'],
                base64: options.Base64 || options.base64 || false
            };
            
            console.log('PrintJS options:', printOptions);
            window.printJS(printOptions);
            
        } else {
            console.log('printJS not available, using fallback');
            // استخدام الطباعة العادية كبديل
            printFallback(options);
        }
        
    } catch (error) {
        console.error('Error in print function:', error);
        // استخدام الطباعة العادية في حالة الخطأ
        printFallback(options);
    }
}

// دالة الطباعة البديلة
function printFallback(options) {
    try {
        const elementId = options.Printable || options.printable;
        const element = document.getElementById(elementId);
        
        if (!element) {
            console.error('Element not found for printing:', elementId);
            return;
        }
        
        // إنشاء نافذة طباعة جديدة
        const printWindow = window.open('', '_blank', 'width=800,height=600');
        
        printWindow.document.write(`
            <html>
            <head>
                <title>طباعة</title>
                <meta charset="utf-8">
                <meta name="viewport" content="width=device-width, initial-scale=1">
                <link rel="preconnect" href="https://fonts.googleapis.com">
                <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
                <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@400;600;700&display=swap" rel="stylesheet">
                <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css">
                <style>
                    * {
                        font-family: 'Cairo', 'Tahoma', Arial, sans-serif !important;
                        direction: rtl !important;
                    }
                    
                    body { 
                        font-family: 'Cairo', 'Tahoma', Arial, sans-serif !important; 
                        direction: rtl !important;
                        text-align: right !important;
                        margin: 0;
                        padding: 10px;
                    }
                    
                    .thermal-receipt {
                        width: 80mm !important;
                        max-width: 300px;
                        margin: 0 auto;
                        direction: rtl !important;
                        text-align: right !important;
                    }
                    
                    .thermal-receipt * {
                        direction: rtl !important;
                        font-family: 'Cairo', 'Tahoma', Arial, sans-serif !important;
                    }
                    
                    .products-header,
                    .product-row,
                    .total-row,
                    .final-total {
                        display: flex !important;
                        justify-content: space-between !important;
                        direction: rtl !important;
                    }
                    
                    .col-name {
                        text-align: right !important;
                        flex: 2;
                    }
                    
                    .col-qty,
                    .col-price,
                    .col-total {
                        text-align: center !important;
                        flex: 1;
                    }
                    
                    @@media print { 
                        body { 
                            margin: 0 !important; 
                            padding: 0 !important;
                            direction: rtl !important;
                        }
                        .no-print { display: none !important; }
                        .thermal-receipt {
                            width: 80mm !important;
                            direction: rtl !important;
                        }
                    }
                    
                    .container { max-width: 100%; }
                    table { width: 100%; direction: rtl; }
                    .text-center { text-align: center !important; }
                    .text-end { text-align: right !important; }
                    .fw-bold { font-weight: bold; }
                    .border { border: 1px solid #dee2e6; }
                    .rounded { border-radius: 0.375rem; }
                    .p-4 { padding: 1.5rem; }
                    .mb-3 { margin-bottom: 1rem; }
                    .mb-4 { margin-bottom: 1.5rem; }
                    .shadow-sm { box-shadow: 0 0.125rem 0.25rem rgba(0, 0, 0, 0.075); }
                </style>
            </head>
            <body dir="rtl">
                ${element.outerHTML}
            </body>
            </html>
        `);
        
        printWindow.document.close();
        
        // انتظار تحميل المحتوى ثم الطباعة
        setTimeout(() => {
            printWindow.print();
            setTimeout(() => {
                printWindow.close();
            }, 1000);
        }, 500);
        
    } catch (error) {
        console.error('Error in printFallback:', error);
        // آخر محاولة - طباعة الصفحة الحالية
        window.print();
    }
}

// دالة طباعة PDF
export function printPDF(elementId, filename = 'document.pdf') {
    try {
        const element = document.getElementById(elementId);
        if (!element) {
            console.error('Element not found for PDF:', elementId);
            return;
        }
        
        if (typeof html2pdf !== 'undefined') {
            const options = {
                margin: 10,
                filename: filename,
                image: { type: 'jpeg', quality: 0.98 },
                html2canvas: { 
                    scale: 2,
                    useCORS: true,
                    allowTaint: true
                },
                jsPDF: { 
                    unit: 'mm', 
                    format: 'a4', 
                    orientation: 'portrait' 
                }
            };
            
            html2pdf().set(options).from(element).save();
        } else {
            console.error('html2pdf library not available');
            // استخدام الطباعة العادية كبديل
            printFallback({ printable: elementId });
        }
        
    } catch (error) {
        console.error('Error in printPDF:', error);
        printFallback({ printable: elementId });
    }
}

// تصدير الدوال للاستخدام العام
window.printDocument = print;
window.printToPDF = printPDF;

console.log('✅ تم تحميل ملف الطباعة بنجاح');