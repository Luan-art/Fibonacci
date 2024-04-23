int posicaoMaxima = 0, atual = 0, penultimo = 0, ultimo = 1, auxiliar = 0;

do
{
    Console.WriteLine("Digite uma posição para chegarmos na sequência Fibonacci:");
    posicaoMaxima = int.Parse(Console.ReadLine());
} while (posicaoMaxima <= 0);

Console.WriteLine("Fibonacci até a posição " + posicaoMaxima);

for (int i = 0; i < posicaoMaxima; i++)
{
    Console.Write(atual + " ");

    auxiliar = atual;
    atual = ultimo;
    ultimo = auxiliar + ultimo;
}
