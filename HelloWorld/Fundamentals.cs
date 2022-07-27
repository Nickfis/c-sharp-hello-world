using System;
namespace HelloWorld
{
    class EmptyClass
    {
            public static void GreetFriend(string friend)
            {
                Console.WriteLine($"Hello {friend}, my friend!");
            }

            public static string LowUpper(string inputString)
            {
                string lower = inputString.ToLower();
                string upper = inputString.ToUpper();
                return $"{lower}{upper}";
            }

            public static int Count(string inputString)
            {
                return inputString.Length;
            }

            public static bool IsEven(int number)
            {
                // TODO
                if (number % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public static void ForLoop()
            {
                // TODO
                for (int i = -3; i < 4; i++)
                {
                    Console.WriteLine(i);
                }
            }

            public static void WhileLoop()
            {
                // TODO
                int counter = -3;

                while (counter < 4)
                {
                    Console.WriteLine(counter);
                    counter++;
                }
            }

        }
}

