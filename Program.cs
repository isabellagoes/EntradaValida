int numeroDigitado = -1;

while (numeroDigitado < 0 || numeroDigitado > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    Int32.TryParse(Console.ReadLine()!, out numeroDigitado);
}

if (numeroDigitado == 0)
{
    Console.WriteLine("\nOperação cancelada.");
}

else
{
    Console.WriteLine($"\nNúmero selecionado = {numeroDigitado}");
}

Console.WriteLine("\nVolte sempre!");