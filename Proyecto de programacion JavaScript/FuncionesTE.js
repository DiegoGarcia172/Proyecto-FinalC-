function CSVToArray(csvText) {
    var lines = csvText.split('\n');
    var result = [];
    for (var i = 0; i < lines.length; i++) {
        // Modifica el siguiente split según el separador utilizado en tu archivo CSV
        var row = lines[i].split('|');
        result.push(row);
    }
    return result;
}
function createTable() {
    var table = document.createElement('table');
    for (var i = 0; i < data.length; i++) {
        var row = document.createElement('tr');
        for (var j = 0; j < data[i].length; j++) {
            var cell = document.createElement(i === 0 ? 'th' : 'td');
            cell.contentEditable = true;
            cell.innerText = data[i][j];
            row.appendChild(cell);
        }
        table.appendChild(row);
    }
    tableContainer.appendChild(table);
}

function exportToXLSX() {
    var wb = XLSX.utils.table_to_book(tableContainer.firstChild);
    XLSX.writeFile(wb, 'tabla.xlsx');
}

function exportToPDF() {
    var element = document.getElementById('tableContainer');
    html2pdf().from(element).save('tabla.pdf');
}

function exportToCSV() {
    var csvContent = [];
    var rows = tableContainer.firstChild.rows;
    for (var i = 0; i < rows.length; i++) {
        var rowData = [];
        var cells = rows[i].cells;
        for (var j = 0; j < cells.length; j++) {
            rowData.push(cells[j].innerText);
        }
        var csvRow = rowData.join('|');
        csvContent.push(csvRow);
    }
    var csvText = csvContent.join('\n');
    var csvData = new Blob([csvText], { type: 'text/csv;charset=utf-8;' });
    var link = document.createElement('a');
    link.href = URL.createObjectURL(csvData);
    link.setAttribute('download', 'tabla.csv');
    link.click();
}