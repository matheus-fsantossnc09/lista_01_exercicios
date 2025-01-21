// Ex - 11 - Crie um programa que peça ao usuário para inserir um número inteiro positivo e então conte de 1 até esse número, exibindo cada número. O programa deve implementar essa contagem usando while.

Console.WriteLine("Digite um número inteiro e positivo");
int num = int.Parse(Console.ReadLine());

Console.Clear();
int contador = 1;
while (contador <= num)
{
    Console.WriteLine("" + contador); contador++;
}
Console.WriteLine("Fim do loop");
