// Ex - 11 - Crie um programa que peça ao usuário para inserir um número inteiro positivo e então conte de 1 até esse número, exibindo cada número. O programa deve implementar essa contagem usando for.

Console.WriteLine("Digite um número inteiro e positivo: ");
int num = int.Parse(Console.ReadLine());
Console.Clear();

for (int contador = 0; contador <= num; contador++)
{
    Console.WriteLine(contador);
}
Console.WriteLine("Fim");
