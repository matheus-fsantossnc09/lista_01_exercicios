/*
 3. Aprovação de Aluno
o Objetivo: Compreender a aplicação de condições para tomada de decisão.
o Descrição: Escreva um programa que pergunte a nota de um aluno. Se a 
nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso 
contrário, ele é "Reprovado". Exiba a situação do aluno na tela.
o Exemplo de Saída: "Aluno aprovado." ou "Aluno reprovado
 */

Console.WriteLine("Digite sua nota ");
int nota1 = int.Parse(Console.ReadLine());

if (nota1 >= 6)
{
    Console.WriteLine("Aluno aprovado");
} else
{
    Console.WriteLine("Aluno reprovado");
}