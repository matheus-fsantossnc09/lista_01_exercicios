﻿/*
 10. Cálculo do Desconto
o Objetivo: Aplicar condições para cálculos.
o Descrição: Escreva um programa que peça o valor de uma compra e 
verifique se o valor é maior que 100. Se sim, aplique um desconto de 10% 
no valor e mostre o valor final. Caso contrário, exiba o valor original.
o Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original: 
[valor
 */

Console.WriteLine("Digite sua compra");
double compra = double.Parse(Console.ReadLine());

if ( compra > 100)
{
    double desconto = compra * 0.10;
    double valorFinal = compra - desconto;
    Console.WriteLine("Valor com desconto: " + valorFinal);
} else
{
    Console.WriteLine("Valor original: " + compra);
}