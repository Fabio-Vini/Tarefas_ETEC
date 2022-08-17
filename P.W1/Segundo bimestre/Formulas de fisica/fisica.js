function abrirMenu () {
    document.getElementById('menu').style.width = '250px';
    document.getElementById('conteudo').style.marginleft = '250px';
}

function fecharMenu() {
    document.getElementById('menu').style.width = '0px';
    document.getElementById('conteudo').style.marginleft = '0px';

}

/*Velocidade Média*/
function CalcVelo() {
    var distancia, tempo, resultado;
   
    distancia = parseInt(document.getElementById('distancia').value);
    tempo = parseInt(document.getElementById('tempo1').value);

    resultado = distancia / tempo;

    document.getElementById('velocidade1').innerHTML = "A velocidade média é:  " + resultado;
}

/*Função MUV*/
function CalcAce() {
    var inicial, aceleracao, tempo, resultado;

    inicial = parseInt(document.getElementById('inicial').value);
    aceleracao = parseInt(document.getElementById('aceleracao2').value);
    tempo = parseInt(document.getElementById('tempo2').value);

    resultado = inicial + (aceleracao * tempo);

    document.getElementById('velocidade2').innerHTML = "A velocidade final é: " + resultado;
}

/*Equação de Torricelli*/
function Calcini() {
    var vi, ac, t, resultado;
   
    vi = parseInt(document.getElementById('veloinicial').value);
    ac = parseInt(document.getElementById('aceleracao3').value);
    t  = parseInt(document.getElementById('tempo3').value);
    
    resultado = Math.pow(vi, 2) + (2 * ac * t);
    
    document.getElementById('velocidade3').innerHTML = "A velocidade final é: " + resultado;
}