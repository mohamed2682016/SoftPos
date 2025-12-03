	function printDiv(elementId) {
		var divContents = document.getElementById(elementId || 'printable-form');
		
		if (!divContents) {
			console.error('Element not found:', elementId || 'printable-form');
			return;
		}

		var opt = {
			margin: 2,
			filename: 'Print.pdf',
			image: { type: 'jpeg', quality: 0.98 },
			html2canvas: { scale: 5 },
			//jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait' }
		};
		html2pdf().set(opt).from(divContents).save();
	}
	
	// دالة طباعة مباشرة للمتصفح
	window.printDiv = function(elementId) {
		try {
			var element = document.getElementById(elementId || 'printable-form');
			if (!element) {
				console.error('Element not found for printing:', elementId);
				return;
			}
			
			var printWindow = window.open('', '_blank');
			printWindow.document.write('<html><head><title>Print</title>');
			printWindow.document.write('<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css">');
			printWindow.document.write('<style>body { font-family: Arial, sans-serif; } @@media print { body { margin: 0; } }</style>');
			printWindow.document.write('</head><body>');
			printWindow.document.write(element.outerHTML);
			printWindow.document.write('</body></html>');
			printWindow.document.close();
			
			setTimeout(function() {
				printWindow.print();
				printWindow.close();
			}, 500);
		} catch (error) {
			console.error('Error in printDiv:', error);
		}
	};
	function printDivWithName(_filename) {
		var divContents = document.getElementById('PDFinvoice');

		var opt = {
			margin: 4,
			filename: _filename + '.pdf',
			image: { type: 'jpeg', quality: 0.98 },
			html2canvas: { scale: 5 },
			jsPDF: {
				orientation: 'p',
				unit: 'mm',
				format: 'a4',
				putOnlyUsedFonts: true,
				floatPrecision: 16 // or "smart", default is 16
			}
			//pagebreak: { before: '#myID', after: ['#after1', '#after2'], avoid: 'img' }
			//pagebreak: { mode: ['avoid-all', 'css', 'legacy'] }
		};
		html2pdf().set(opt).from(divContents).save();
	}

	window.PrintPdf = () => {
		var divContents = document.getElementById('PDFinvoice');




		var opt = {
			margin: 2,
			filename: 'PurchaseInvoice.pdf',
			image: { type: 'jpeg', quality: 0.98 },
			html2canvas: { scale: 5 },
			//jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait' }
		};

		// New Promise-based usage:
		html2pdf().set(opt).from(divContents).save();

		//html2pdf(divContents, opt);
	};
// Select 2 - تحقق من وجود jQuery أولاً
if (typeof $ !== 'undefined' && $('.select').length > 0) {
	$('.select').select2({
		minimumResultsForSearch: -1,
		width: '100%'
	});
}
	function exportToExcel(_filename) {
		var location = 'data:application/vnd.ms-excel;base64,';
		var excelTemplate = '<html> ' +
			'<head> ' +
			'<meta http-equiv="content-type" content="text/plain; charset=UTF-8"/> ' +
			'</head> ' +
			'<body> ' +
			document.getElementById(_filename).innerHTML +
			'</body> ' +
			'</html>'
		window.location.href = location + window.btoa(excelTemplate);
}



function renderSalesChart(months, totals) {
	const ctx = document.getElementById('salesChart').getContext('2d');
	const parsedMonths = JSON.parse(months);
	const parsedTotals = JSON.parse(totals);

	new Chart(ctx, {
		type: 'line',
		data: {
			labels: parsedMonths,
			datasets: [
				{
					label: 'Sales',
					data: parsedTotals,
					borderColor: 'rgba(75, 192, 192, 1)',
					backgroundColor: 'rgba(75, 192, 192, 0.2)',
					borderWidth: 2,
				},
			],
		},
		options: {
			responsive: true,
			plugins: {
				legend: {
					display: true,
				},
			},
			scales: {
				x: {
					title: {
						display: true,
						text: 'Months',
					},
				},
				y: {
					title: {
						display: true,
						text: 'Grand Total',
					},
				},
			},
		},
	});
}

