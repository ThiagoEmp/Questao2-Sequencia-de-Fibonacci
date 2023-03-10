using System;
class Program
{
    //Questão 2 - SEQUÊNCIA DE FIBONACCI
    static void Main()
    {

        int num1 = 0;
        int num2 = 1;
        int numSelecionado = 0;
        bool estaNaSequencia = false;


        Console.WriteLine("Insira um número: ");
        numSelecionado = int.Parse(Console.ReadLine());

        while (num1 <= numSelecionado)
        {
            if(num1 == numSelecionado)
            {
                estaNaSequencia = true;
            }
            else if(num2 == numSelecionado)
            {
                estaNaSequencia = true;
            }
            Console.Write(num1 + " " + num2 + " ");
            num1 += num2;
            num2 += num1;

            

        }

        if(estaNaSequencia)
        {
            Console.WriteLine("\nO número inserido está na sequência de Fibonacci");
        }
        else
        {
            Console.WriteLine("\nO número inserido não está na sequência de Fibonacci");

        }


        Console.Read();
    }
}
