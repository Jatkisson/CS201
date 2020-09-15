using System;
using System.Collections.Generic;
using System.Text;

namespace Unit03LabProgram2
{
    public class ProcessInput
    {
        public static void InputProcessor(int value)
        {
            //Write the corresponding season or an error message
            switch (value)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("\nwinter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("\nspring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("\nsummer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("\nfall");
                    break;
                default:
                    Console.Write("\nI’m sorry, an invalid month was entered.");
                    break;
            }
        }
    }

}
