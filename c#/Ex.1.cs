using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] recebe = new int [5];

    Console.WriteLine("Digite o 1° número: ");
    recebe[0] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 2° número: ");
    recebe[1] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 3° número: ");
    recebe[2] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 4° número: ");
    recebe[3] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 5° número: ");
    recebe[4] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Os números digitados foram: " +       recebe[0] + ", " + recebe[1] + ", " + recebe[2] + ", " + recebe[3] + " e " + recebe[4]);
  }
}