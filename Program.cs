double media, nota1, nota2, nota3, nota4;
string resultado;

Console.WriteLine("-----MEDIA DAS 4 NOTAS-----");
Console.WriteLine("Digite as suas notas abaixo:");
Console.WriteLine();

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());


bool NotasValidas = nota1 >= 0 && nota1 <= 10
                 && nota2 >= 0 && nota2 <= 10
                 && nota3 >= 0 && nota3 <= 10
                 && nota4 >= 0 && nota4 <= 10;


if(NotasValidas)
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;

    if (media < 5)
    {
    resultado = "Reprovado";
    }
    else if (media > 6)
        {
            resultado = "Aprovado";
        }
        else
        {
            resultado = "Em recuperação";
        }

    Console.WriteLine($"Você ficou com a média {media:N1}. Resultado: {resultado}");    
}
else
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}


