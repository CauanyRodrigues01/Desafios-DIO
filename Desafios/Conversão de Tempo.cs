/*
Desafio
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
*/
  
using System;

public class loja
{
    public static void Main()
    {
        string[] line = Console.ReadLine().Split(" ");
        int tempoSegundos = int.Parse(line[0]);

        int horas = tempoSegundos / 3600;
        int minutos = (tempoSegundos % 3600) / 60;
        int segundos = (tempoSegundos % 3600) % 60;

        Console.Write($"{horas}:{minutos}:{segundos}");
    }
}