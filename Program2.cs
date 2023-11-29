/*
  Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja 
realizar: 
1 – Verificar se um dos números lidos é ou não múltiplo do outro 
2 – Verificar se os dois números lidos são pares 
3 – Verificar se a média dos dois números é maior ou igual a 7. 
4 – Sair
 */

using System.Net.Http.Headers;

static void opcoesMenu()
{
    Console.WriteLine("SELECIONE UMA OPÇÃO : ");
    Console.WriteLine("\n\n\n1. Verificar se um dos números lidos é ou não múltiplo do outro");
    Console.WriteLine("2. Verificar se os dois números lidos são pares ");
    Console.WriteLine("3. Verificar se a média dos dois números é maior ou igual a 7.  ");
    Console.WriteLine("4. Sair ");

    Console.WriteLine("\n\nSelecione a opção que deseja selecionar : ");
    int opcaoSelecionada = int.Parse(Console.ReadLine()!);   

    switch (opcaoSelecionada)
    {
        case 1:
            verificarMultiplos();
            break;
        case 2:
            verificarParImpar();
            break;
        case 3:
            verificarMediaSete();
            break;
        case 4:
            close();
            break;
        default:
            nenhumaOpcaoVoltarMenu();
            break;
    }

    void verificarMultiplos()
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção 1 (Verificar se um dos números lidos é ou não multiplo do outro) ");

        Console.WriteLine("\nDigite um número inteiro : ");
        int numeroUmVerificacao = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nDigite um segundo número inteiro : ");
        int numeroDoisVerificacao = int.Parse(Console.ReadLine()!);

        if (numeroUmVerificacao % numeroDoisVerificacao == 0 || numeroDoisVerificacao % numeroUmVerificacao == 0)
        {
            Console.WriteLine($"\n\nO{numeroUmVerificacao} é multiplo do {numeroDoisVerificacao} ou vice-versa");
        }else
        {
            Console.WriteLine($"\n\nO {numeroUmVerificacao} não é multiplo do {numeroDoisVerificacao} ou vice-versa");
        }

        Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        opcoesMenu();
    }

    void verificarParImpar()
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção 2 (Verificar se os dois números lidso são pares");

        Console.WriteLine("\nDigite um número inteiro : ");
        int numUmParImpar = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nDigite um segundo número inteiro : ");
        int numDoisParImpar = int.Parse(Console.ReadLine()!);

        if (numUmParImpar % 2 == 0 || numDoisParImpar % 2 == 0)
        {
            Console.WriteLine("\n\nAmbos os numeros são pares");
        }
        else
        {
            Console.WriteLine("\n\nOs números digitados não são pares");
        }

        Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        opcoesMenu();
    }

    void verificarMediaSete()
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção 3 (Verificar se a média dos dois números é maior ou igual a 7.)");

        Console.WriteLine("\nDigite um número inteiro : ");
        int numUmMedia = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nDigite um segundo número inteiro : ");
        int numDoisMedia = int.Parse(Console.ReadLine()!);

        int mediaNumeros = (numUmMedia + numDoisMedia) / 2;

        if (mediaNumeros >= 7)
        {
            Console.WriteLine("\nA média dos dois números é igual ou superior a 7");
        }
        else
        {
            Console.WriteLine("\nA média dos dois numero não é igual ou superior a 7");
        }

        Console.WriteLine("\n\nTecle qualquer coisa para retornar ao menu");
        Console.ReadKey(); 
        Console.Clear();
        opcoesMenu();
    }
    
    void close()
    {
        Console.Clear();
        Console.WriteLine("Você selecinou a opção 4 (Sair)");

        Console.WriteLine("\n\nTecle qualquer coisa duas vezes para sair\n\n\n\n");
        Console.ReadKey();
    }
    void nenhumaOpcaoVoltarMenu()
    {
        Console.Clear();
        Console.WriteLine("Você não selecionou nenhuma opção válida, retornando ao menu em 1,2,3..");

        Thread.Sleep(2000);
        Console.Clear();
        opcoesMenu();
    }
}

opcoesMenu();