using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett ord: "); string Input = Console.ReadLine().ToLower();
            Console.WriteLine();
            char[] InputBS = Input.ToCharArray();
            bool finns = false;

            Array.Sort(InputBS);

            // Går igenom bokstäverna en efter en
            for (int i = 0; i < InputBS.Length; i++)
            {

                // Kollar om någon av de andra bokstäverna är samma bokstav
                for (int j = 0; j < InputBS.Length; j++)
                {

                    if (j != i && InputBS[i] == InputBS[j])
                    {
                        if (i != 0 && InputBS[i - 1] == InputBS[j])
                        {
                            break;
                        }
                        else
                        {
                            finns = true;
                            Console.WriteLine($"Bokstaven \"{InputBS[i]}\" finns fler än en gång i ordet.");
                            break;
                        }
                    }
                }
            }

            if (finns == false)
            {
                Console.WriteLine("Ingen av bokstäverna i ordet finns fler än en gång.");
            }
        }
    }
}

