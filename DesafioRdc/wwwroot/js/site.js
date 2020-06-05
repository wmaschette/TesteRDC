function ValidarSinaisEntrada() {
    let text = $("#InputSinais").val();

    if (!text.trim()) {
        alert("Por favor, informe sinais válidos!");
        return false;
    }

    let data = text.replace(/\s/g, '').split(',');

    $.ajax({
        url: '/ProblemaSinais/VerificarSinais',
        dataType: 'json',
        method: 'post',
        data: { dados: data }
    }).done(function (data) {
        CriarDivResultadoSinais(data);
    }).fail(function (xhr, status, error) {
        alert(xhr.responseJSON.erro);
    })
}

function CriarDivResultadoSinais(dados) {
    var divResultado = $("#divResultado");
    divResultado.empty();
    for (dado of dados) {
        let classColor = "";
        if (!dado.balanceado) {
            classColor = "text-danger";
        } else {
            classColor = "text-primary";
        }
        divResultado.append("<p class='text-center " + classColor + " font-weight-bold'>" + dado.caracteres + " = " + dado.balanceado + "</p><br />");
    }
}

function SalvarRian() {
    let text = $("#InputSoldados").val();

    if (!text.trim() || text < 2) {
        alert("Por favor, informe uma quantidade de soldados válida!");
        return false;
    }

    $.ajax({
        url: '/SalveRian/VerificarSobrevivente',
        dataType: 'json',
        method: 'post',
        data: { quantidade: text }
    }).done(function (data) {
        CriarDivResultadoRian(data);
    }).fail(function (xhr, status, error) {
        alert(xhr.responseJSON.erro);
    })
}

function CriarDivResultadoRian(dados) {
    var divResultado = $("#divResultado");
    divResultado.empty();
    divResultado.append("<p class='text-center text-primary font-weight-bold'>Com " + dados.quantidade + " soldados, Rian deveria sentar na posição " + dados.posicaoSobrevivente + "</p>");
}