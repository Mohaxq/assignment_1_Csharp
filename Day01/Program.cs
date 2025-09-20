namespace Day01
{
    internal class Program
    {
        class point
        {
          public  int x, y;
        }
        static void Main(string[] args)
        {
            /*//1
            Console.WriteLine("enter number: ");
            int user = int.Parse(Console.ReadLine());
            Console.WriteLine($"you entered: {user}");
            */

            /* //2
             string x = "hello";
             int y = int(x); //it will give error
            */

            //3
            /*float a = 5.5f;
            float b = 2.2f;
            float c = a + b;
            Console.WriteLine(c); // it will print 7.7
            */

            //4
            /*string x = "hello";
            string y = x.Substring(1, 3);
            Console.WriteLine(y); // it will print ell*/

            //5
            /* int a = 5;
             int b = a;
             a = 3;
             Console.WriteLine(b); // it will print 5
             Console.WriteLine(a); // it will print 3 without change in b
            */

            //6
           /* point p1 = new point()
            {
                x = 5,
                y = 10
            };
            point p2 = p1;
            Console.WriteLine(p2.x); // it will print 5
            p1.x = 20;
            Console.WriteLine(p2.x); // it will print 20 because p2 is reference of p1*/

            //7
            /* string x = "hello";
             string y = "World";
             string z = x + " " + y;
             Console.WriteLine(z); // it will print hello World
            */

            //8
            /* Console.WriteLine("enter principal amount: ");
             int principal = int.Parse(Console.ReadLine());
             Console.WriteLine("enter rate: ");
             float rate = float.Parse(Console.ReadLine());
             Console.WriteLine("enter time: ");
             int time = int.Parse(Console.ReadLine());
             float simpleInterest = (principal * rate * time) / 100;
             Console.WriteLine($"simple interest is: {simpleInterest}");*/

            //9
            /*Console.WriteLine("enter your weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your height: ");
            int height = int.Parse(Console.ReadLine());
            float bmi = weight / (height * height);
            Console.WriteLine($"your bmi is: {bmi}");*/

            //10
            /*Console.WriteLine("enter temperature: ");
            float celsius = float.Parse(Console.ReadLine());
            Console.WriteLine((celsius<10?"just cold":(celsius>30?"just hot":"just good")));*/

            //11
            /*Console.WriteLine("enter day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"you entered date is: {day}/{month}/{year}");
            Console.WriteLine($"you entered date is: {day},{month},{year}");
            Console.WriteLine($"you entered date is: {day}-{month}-{year}");
            */

            //12
            /*DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");// answer is c*/

            //13
            /*int d;
            d = Convert.ToInt32(!(30 < 20));
            // answer is f*/

            //14
            //Console.WriteLine(13 / 2 + " " + 13 % 2); // answer is d

            //15
            /*int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            // answer is d
            */

        }
    }
}

