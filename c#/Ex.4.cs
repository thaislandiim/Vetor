using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] numero = new int[4];

    Console.WriteLine("Digite um número: ");
    numero[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Exiba o 1° numero: " + numero[0]);

    
    numero[1] = numero[0] + 5;
    Console.WriteLine("Exiba o 2° numero: " + numero[1]);
    numero[2] = numero[1] + 5;
    Console.WriteLine("Exiba o 3° numero: " +numero[2]);
    numero[3] = numero[2] + 5;
    Console.WriteLine("Exiba o 4° numero: " +numero[3]);
  }
}