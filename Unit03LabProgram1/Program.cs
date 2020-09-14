using System;

/**
 * @author James Atkisson
 * Class Program to compute an area or circumference given 
 * a user-entered radius and desired choice. */
class Program
{
    static void Main(string[] args)
    {
        //Call the function to get the radius
        double radius = PromptUserValue("radius (feet)");

        // Ensure the radius is valid
        if (radius > 0)
        {
            //Get the user choice of Area or Circumference
            String areaOrCirc = PromptAreaOrCirc();

            if (areaOrCirc == "a" || areaOrCirc == "A")
            {
                double area = Math.PI * radius * radius;
                Console.Write($"Area: {area:N4} square feet");
            }
            else if (areaOrCirc == "c" || areaOrCirc == "C")
            {
                double circumference = 2 * Math.PI * radius;
                Console.Write($"Circumference: {circumference:N4} feet");
            }
            else
            {
                Console.Write("I'm sorry, I did not " +
                    "understand your choice.");
            }
        }
        else
        {
            Console.Write("I'm sorry, an invalid radius was entered.");
        }

    }

    static public double PromptUserValue(string valuePrompted)
    {
        //Prompt the user for the first integer
        Console.Write($"Enter the {valuePrompted}: ");
        double value = Convert.ToDouble(Console.ReadLine());

        return value;
    }

    static public String PromptAreaOrCirc()
    {

        //Prompt the user for A (Area) or C (Circumference)
        Console.Write("Enter A (Area) or C (Circumference): ");
        String selection = (Console.ReadLine());
        
        return selection;
    }

}
