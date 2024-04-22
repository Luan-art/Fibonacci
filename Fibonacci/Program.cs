int max = 0, numeroA = 1, numeroB = 1, aux = 0;

do
{
    Console.WriteLine("Digite uma posicão para chegarmos na sequência FIbonacci");
    max = int.Parse(Console.ReadLine());

} while (max <= 0);

Console.WriteLine("Fibonacci até a posição " + max);

for (int i = 0; i < max; i++)
{
    Console.Write(numeroA + " ");

    aux = numeroA;
    numeroA = numeroB;
    numeroB = aux + numeroB;
}