﻿/*
Ex.01 Verificação de paridade

Objetivo: Pratique o uso do operador % (módulo) e estruturas condicionais simples. 
Descrição: Crie um programa que solicite que o usuário digite um número inteiro. O programa deve verificar se o número é par ou ímpar. Use a condição if para determinar o resultado e exibir uma mensagem apropriada. 
Exemplo de saída: "O número é par." ou "O número é ímpar".

*/

Console.WriteLine("Digite um número");

int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par ");
}
else
{
    Console.WriteLine("O número é ímapar");
}