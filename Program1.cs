/*
  Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
1 – Adição 
2 – Subtração 
3 – Multiplicação 
4 – Divisão
 */

void opcoesMenu()
{
    Console.WriteLine("1. Adição");
    Console.WriteLine("2. Subtração");
    Console.WriteLine("3. Multiplicação");
    Console.WriteLine("4. Divisão");
    Console.WriteLine("5. Fechar o programa");

    Console.WriteLine("\nDigite a opção que deseja executar :");
    int opcaoSelecionada = int.Parse(Console.ReadLine()!);

   switch (opcaoSelecionada)
    {
        case 1:
            adicao();
            break;
        case 2:
            subtracao();
            break;
        case 3:
            multiplicacao();
            break;
        case 4:
            divisao();
            break;
        default:
            close();
            break;

    }

    void adicao()
    {
        Console.Clear();

        Console.WriteLine("Você selecionou a opção ADIÇÃO");

        Console.Write("\nDigite um número : ");
        int primeiroNumero = int.Parse(Console.ReadLine()!);


        Console.WriteLine("\nDigite um segundo número : ");
        int segundoNumero = int.Parse(Console.ReadLine()!);

        int somaDosNumeros = primeiroNumero + segundoNumero;
        Console.WriteLine($"\n\nA soma dos dois números é : {somaDosNumeros}");

        Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        opcoesMenu();
    }

    void subtracao()
    {
        Console.Clear();

        Console.WriteLine("Você selecionou a opção SUBTRAÇÃO");

        Console.Write("\nDigite um número : ");
        int primeiroNumeroSub = int.Parse(Console.ReadLine()!);

        Console.Write("\nDigite um segundo número : ");
        int segundoNumeroSub = int.Parse(Console.ReadLine()!);  

        int subtracaoNumeros = primeiroNumeroSub - segundoNumeroSub;
        Console.WriteLine($"\n\nA subtração dos dois numeros é : {subtracaoNumeros}");

        Console.WriteLine("\n\nTecle qualquer coisa para voltar ao menu");
        Console.ReadKey();  
        Console.Clear();
        opcoesMenu();
    }

    void multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Você selecionou a opção MULTIPLICAÇÃO");

        Console.Write("\nDigite um número : ");
        int primeiroNumeroMult = int.Parse(Console.ReadLine()!);

        Console.Write("\nDigite um segundo número : ");
        int segundoNumeroMult = int.Parse(Console.ReadLine()!);

        int multiplicacaoNumeros = primeiroNumeroMult * segundoNumeroMult;
        Console.Write($"\n\nA multiplicação dos dois numeros é : {multiplicacaoNumeros}");

        Console.WriteLine("\n\nTecle qualquer coisa para voltar ao menu");
        Console.ReadKey(); 
        Console.Clear(); 
        opcoesMenu();
    }

    void divisao()
    {
        Console.Clear();

        Console.WriteLine("Você selecionouu a opção DIVISÃO");

        Console.Write("\nDigite uum número : ");
        int primeiroNumeroDiv = int.Parse(Console.ReadLine()!);

        Console.Write("\nDigite um segundo número : ");
        int segundoNumeroDiv = int.Parse(Console.ReadLine()!); 

        int divisaoNumeros = primeiroNumeroDiv / segundoNumeroDiv;
        Console.Write($"\n\nA divisão dos dois numeros é : {divisaoNumeros}");

        Console.WriteLine("\n\nTecle qualquer coisa para voltar ao menu");
        Console.ReadKey(); 
        Console.Clear(); 
        opcoesMenu();

    }

    void close()
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção FECHAR O PROGRAMA");

        Console.Write("\n\nPara fechar o programa tecle qualquer coisa\n\n\n\n\n");
    }
}

opcoesMenu();
