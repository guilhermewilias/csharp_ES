/*
 Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, 
utilizando as seguintes fórmulas: (h = altura) 
- Para homens: (72.7*h) - 58 
- Para mulheres: (62.1 *h) - 44.7 
 */

static void main()
{
    Console.WriteLine("Digite a altura da pessoa : ");
    double alturaPessoa = double.Parse(Console.ReadLine()!);


    Console.WriteLine("\nDigite o sexo da pessoa (M para Msculino, F para Feminino) ");
    char sexo = Convert.ToChar(Console.ReadLine()!.ToUpper()!);


    double pesoIdealHomem = (72.7 * alturaPessoa) - 58;
    double pesoIdealMulher = (62.1 * alturaPessoa) - 44.7;

    if (sexo =='M')
    {
        Console.WriteLine($"\n\nCom esta altura, o peso ideal para o sexo masculino é : {pesoIdealHomem:F1} kg");
    }else if (sexo == 'F')
    {
        Console.WriteLine($"\n\nCom esta altura, o peso ideal para o sexo feminino é : {pesoIdealMulher:F1} kg");
    }
    else
    {
        Console.WriteLine("\n\nSexo inválido, insira M para Masculino e F para Feminino");
    }

  

    /*
    Console.WriteLine($"Com esta altura, o peso ideal para o sexo masculino é : {pesoIdealHomem}");
    Console.WriteLine($"Com esta altura, o peso ideal para o sexo feminino é : {pesoIdealMulher}");
    */

}

main();