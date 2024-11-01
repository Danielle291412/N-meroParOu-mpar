ExibirTítulo();
Console.Write("Informe um número:");
int numero = Convert.ToInt32(Console.ReadLine());
bool ehPar = DefinirPar(numero);

DefinirPar(numero);
ExibirResultado();

void ExibirTítulo()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("----------------------");
    Console.WriteLine("-----Par ou Ímpar-----");
    Console.WriteLine("--------------------\n");
    Console.ResetColor();
}

bool DefinirPar(int numero)
{
    bool ehPar = numero % 2 == 0;
    return ehPar;
}

void ExibirResultado()
{
    Console.WriteLine($"O número {numero} é {(ehPar ? "Par" : "Ímpar")}");
}
