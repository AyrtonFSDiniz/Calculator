Menu();

static void Menu() {

Console.Clear();

Console.WriteLine("Olá! Bem Vinda a Calculadora Wherever!");
Console.WriteLine("...");
Console.WriteLine("Qual operação que deseja executar?");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Divisão");
Console.WriteLine("4 - Multiplicação");
Console.WriteLine("5 - Juros Compostos");
Console.WriteLine("6 - IMC");
Console.WriteLine("7 - Sair");

Console.WriteLine("################################");

Console.WriteLine("Selecione uma opção:");
short res = short.Parse(Console.ReadLine());

    switch (res) {
        case 1: Soma();
        break;

        case 2: Subtracao();
        break;

        case 3: Divisao();
        break;

        case 4: Multiplicacao();
        break;

        case 5: JurosCompostos();
        break;

        case 6: IMC();
        break;

        case 7: System.Environment.Exit(0);
        break;

        default: Menu();
        break;
    }
}

static void Soma()
{
    Console.Clear();

Console.WriteLine("Primeiro valor:");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Segundo valor:");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine("");

float resultadoSoma = v1 + v2;
Console.WriteLine($"O resultado da soma é {resultadoSoma}.");
Console.ReadKey();
Menu();
}

static void Subtracao() {
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("");

    float resultadoSubtracao = v1 - v2;
    Console.WriteLine($"O resultado da subtracao é {resultadoSubtracao}.");
    Console.ReadKey();
    Menu();
}

static void Divisao() {
    
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultadoDivisao = v1 / v2;
    Console.WriteLine($"O resultado da divisao é {resultadoDivisao}.");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao () {
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float resultadoMultiplicacao = v1 * v2;

    Console.WriteLine($"O resultado multiplicação é {resultadoMultiplicacao}.");
    Console.ReadKey();
    Menu();

}

static void JurosCompostos() {
    Console.Clear();

    Console.WriteLine("Informe o valor do capital aplicado (valor que pediu emprestado):");
    double capital = double.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Informe a taxa de juros do seu financiamento:");
    double juros = double.Parse(Console.ReadLine());
    double jurosCorrigido = juros/100;
    Console.WriteLine("");

    Console.WriteLine("Informe o tempo em meses do financiamento (ou a quantidade de parcelas):");
    int tempo = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    double resultadoJurosCompostos = capital * (Math.Pow((1 + jurosCorrigido), tempo));

    Console.WriteLine($"O valor total a pagar do financiamento, que era {capital} passou a ser de {resultadoJurosCompostos} em {tempo} meses.");
    Console.ReadKey();
    Menu();
}

static void IMC() {
    Console.Clear();

    Console.WriteLine("Qual é seu peso?");
    double peso = double.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Qual é sua altura?");
    double altura = double.Parse(Console.ReadLine());
    Console.WriteLine("");

    double resultadoIMC = peso / (Math.Pow(altura, altura));

    Console.WriteLine($"O valor do seu IMC é {resultadoIMC}. A efeito de comparação, vide tabela a seguir:");
    Console.WriteLine("Menor que 18.5 - Abaixo do peso;");
    Console.WriteLine("Entre 18.5 e 24.9 - Peso normal;");
    Console.WriteLine("Entre 25.0 e 29.9 - Pré-obesidade;");
    Console.WriteLine("Entre 30.0 e 34.9 - Obesidade Grau 1;");
    Console.WriteLine("Entre 35.0 e 39.9 - Obesidade Grau 2;");
    Console.WriteLine("Acima de 40 - Obesidade Grau 3.");
    Console.ReadKey();
    Menu();
    
}

