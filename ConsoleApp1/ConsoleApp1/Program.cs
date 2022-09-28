using System;
using System.Security.AccessControl;

public class condicaoSE
{





    public static void Main(string[] args)
    {
        //quero programa para validar a idade de uma pessoa, e saber se ela é maior de idade ou nao
        int idade;

        Console.WriteLine("qual sua idade!! ");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("_________________________");
            Console.WriteLine("Opa.. voce e maior de idade!");
            Console.WriteLine("____________________________");

        }
        else
        {
            Console.WriteLine("Opa.. nao tem altorizacao!!");
            Console.WriteLine("__________________________");


        }




        }


    }

