namespace Topic_3___Variables_Assignment__Renewed_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aron John E. Bautista Topic 3 - Variables Programming Assistant
            Console.WriteLine("Part 1");
            string course;

            int myRoom = 29;
            double price = 2.99;
            course = "Computer Science!";
            //These are the things i need or these things are the given
            Console.WriteLine("This is room #" + myRoom);
            Console.WriteLine("The price is $" + price);
            Console.WriteLine("I am interested in " + course);
            Console.WriteLine("");
            //Part 1 done
            Console.WriteLine("Part 2");
            string name;

            Console.WriteLine("Enter your name!");
            name = Console.ReadLine();
            int graduationyear;
            graduationyear = 6;
            Console.WriteLine("Hello there, " + name + " and you'll graduate in " + graduationyear + " years.");
            Console.WriteLine("");
            //Part 2 done

            Console.WriteLine("Part 3:");
            Console.WriteLine("Give me a radius of a circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If radius is" + radius + " then " );
            Console.WriteLine(radius + " * pi");
            Console.WriteLine("So the area of the radius that you have given is: " + radius * 3.14);
            Console.WriteLine("");
            //Part 3 done
            Console.WriteLine("Part 4:");
            Console.WriteLine("My fav math formula is: ");
            Console.WriteLine("(a + b)3 = c3 + d3 =");
            Console.WriteLine("");
            Console.WriteLine("For Ex. (3 + 6)^3 = 2^3 + 7^3 = 27");
            Console.WriteLine("If you wanna try enter the following:");
            Console.WriteLine("(a + b)^3 enter the variables for a and b");
            Console.WriteLine("a is ?");
            int firstvariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b is ?");
            int secondvariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now c and d (NOTE: C AND D WHEN ADDED HAS TO BE THE SAME WITH a AND b");
            Console.WriteLine("c is ?");
            int thirdvariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d is ?");
            int fourthvariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So, " + "(" + firstvariable + " + " + secondvariable + ")^3 = " + thirdvariable + "^3 + " + fourthvariable + "^3 = " + (thirdvariable * 3 + fourthvariable * 3));
        }
    }
}
