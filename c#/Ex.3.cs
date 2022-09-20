using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] numero = new int[3];

    Console.WriteLine("Digite um número: ");
    numero[0] = Convert.ToInt32(Console.ReadLine());

    numero[1] = numero[0] * 2;
    numero[2] = numero[1] * 2;

    Console.WriteLine("Exiba o 1° número: " + numero[0] + ". Exiba o 2° número: " + numero[1] + ". Exiba o 3° número " + numero[2]);
  }
}