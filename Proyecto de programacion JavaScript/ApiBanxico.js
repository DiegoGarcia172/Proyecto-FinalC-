function realizarConsulta() {
    var fechaInicio = document.getElementById('fechaInicio').value;
    var fechaFin = document.getElementById('fechaFin').value;
    if (fechaInicio && fechaFin) {
        var url = 'https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/' + fechaInicio + '/' + fechaFin + '?token=4b61cf0ec98bd9264330eabef1ea9c6f1c94e550e7054173d6db83658e4aa1d9';
        $.ajax({
            url: url,
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                mostrarResultado(data);
            },
            error: function (error) {
                console.log(error);
            }
        });
    } else {
        alert('Por favor, selecciona la fecha de inicio y fin.');
    }
}
function mostrarResultado(data) {
    var resultadoDiv = document.getElementById('resultado');
    resultadoDiv.innerHTML = '';

    if (data.bmx.series.length > 0) {
        var serie = data.bmx.series[0];
        var registros = serie.datos;

        if (registros.length > 0) {
            for (var i = 0; i < registros.length; i++) {
                resultadoDiv.innerHTML += registros[i].fecha + ': ' + registros[i].dato + '<br>';
            }
        } else {
            resultadoDiv.innerHTML = 'No se encontraron registros.';
        }
    } else {
        resultadoDiv.innerHTML = 'No se encontró la serie solicitada.';
    }
}