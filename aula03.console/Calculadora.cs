static double somar(double v1, double v2){
    return v1 + v2;
}

static double subtrair(double v1, double v2){
    return v1 - v2;
}

static double multiplicar(double v1, double v2){
    return v1 * v2;
}

static double dividir(double v1, double v2)
{
    double resultado = 0;

    if (v2 != 0){
        resultado = v1 / v2;
    }
    else{
        Console.WriteLine("Segundo termo não deve ser zero!");
    }
    return resultado;
}
int opcao = 0;
double valor1, valor2, resultado = 0;

Console.WriteLine("Calculadora");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.WriteLine("4 - Dividir");

Console.WriteLine("Informe uma opção:");
opcao = int.Parse(Console.ReadLine());

if(opcao == 9){
    Console.WriteLine("Muito obrigado! Tchau");
}else

Console.WriteLine("Informe o valor 1:");
valor1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor 2:");
valor2 = double.Parse(Console.ReadLine());

if (opcao == 1){
    resultado = somar(valor1, valor2);
}
else if (opcao == 2){
    resultado = subtrair(valor1, valor2);
}
else if (opcao == 3){
    resultado = multiplicar(valor1, valor2);
}

Console.WriteLine("Resultado: " + resultado);
Console.ReadKey();
