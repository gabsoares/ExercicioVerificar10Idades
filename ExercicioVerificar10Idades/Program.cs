int idade = 1, contador = 0, menorIdade = 0, maiorIdade = 0;

while (contador < 10 && idade > 0)
{
    Console.Write("Digite uma idade: ");
    idade = int.Parse(Console.ReadLine());
        if (idade >= 18)
        {
            maiorIdade++;
        }
        else
        {
            menorIdade++;
        }

    contador++;
}

if (idade > 0)
{
    Console.WriteLine($"O número de pessoas com idade de 18 ou acima: {maiorIdade}");
    Console.WriteLine($"O número de pessoas com menos de 18 anos: {menorIdade}");
}
else
{
    Console.WriteLine("Não existe pessoa com 0 anos de idade");
}




