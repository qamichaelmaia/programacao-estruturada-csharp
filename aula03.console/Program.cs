// VARIÁVEIS
// 2 GRUPOS, 4 TIPOS: NUMÉRICAS E LITERAIS
// NÚMERICAS: INTEIROS e REAIS
// LITERAIS: LETRA e TEXTO

// TOMADA DE DECISÃO (DESVIO) - AULA ANTERIOR
// SISTEMA ESPECIALISTA (IA)
// DETECÇÃO DE DOENÇAS - DENGUE
// SE/SENÃO - IF/ELSE

// TENHO DINHEIRO PARA UMA CASQUINHA NO MC?
/*
float mesada;

Console.WriteLine("Quanto você ganha:");
mesada = float.Parse(Console.ReadLine());

// Expressão VERDADE: BOOLEANA
// MESADA É MENOR QUE 14,90?
if (mesada < 14.90f){  //f = float
    Console.WriteLine("Você não tem dinheiro para o McFlurry");
}

else{
    Console.WriteLine("Baunilha, Chocolate ou Misto?");
}*/



// REPETIR:
// LAÇOS DE REPETIÇÃO
// TRÊS LAÇOS NA P. ESTRUTURADA: for (PARA)
// NA PROGRAMAÇÃO O. A OBJETOS: "foreach" (PARA CADA)
// ESTRUTURA DO LAÇO: INÍCIO, CONDIÇÃO DE PARADA E INCREMENTO

// valor++ mesmo que valor = valor + 1

/*int valor;

for (valor = 1; valor <=200; valor++){
    Console.WriteLine(valor + " Michael Douglas");
}*/
/*
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);
Console.WriteLine(6);
Console.WriteLine(7);
Console.WriteLine(8);
Console.WriteLine(9);
Console.WriteLine(10);*/


// TABUADA
int valor;
int valor2;

for(valor = 1; valor<=10; valor++) {
    for(valor2 = 1; valor2 <= 10; valor2 ++ ){
        Console.Write(valor * valor2 + " | "); // Para pular uma linha
    }

    Console.WriteLine();
}
