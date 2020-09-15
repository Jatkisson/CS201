using System;
using System.ComponentModel.DataAnnotations;

/**
 * @author James Atkisson
 * Class Program that displays Welcome text on run*/

class Program
{
    static void Main(string[] args)
    {
        int grade = 108;

        switch (grade / 10)
        {
            case 10:
            case 9:
                Console.Write("A");
                break;
            default:
                Console.Write("F");
                break;
        }

        Console.Write(108 / 10);
    }
}   