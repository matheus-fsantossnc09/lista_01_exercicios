// Ex - 11 - Crie um programa que peça ao usuário para inserir um número inteiro positivo e então conte de 1 até esse número, exibindo cada número. O programa deve implementar essa contagem usando do while.

Console.WriteLine("Digite um número inteiro positivo");
int num = int.Parse(Console.ReadLine());
Console.Clear();
int contador = 0;

do
{
    Console.WriteLine("" + contador); contador++;
} while (contador <= num);

Console.WriteLine("Fim do loop");

