using System;
using System.ComponentModel.Design;
using System.Runtime.Serialization;
class HelloWorld
{
    static string[,] xo = new string[3,3];
    static int g = 0;
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {


                xo[i, j] = "*";


            }
        }
        var game = true;
        while (game)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    

                    Console.Write($"{ xo[i, j]}");


                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nP1-Turn");
            for (int i = 0; i < 1;)
            {
                Console.Write("x:");
                if (int.TryParse(Console.ReadLine(), out var x)) 
                {
                    Console.Write("y:");
                    if (int.TryParse(Console.ReadLine(), out var y)) 
                    {
                        if (y > 0 && y < 4 && x > 0 && x < 4 && xo[y - 1, x - 1] != "x" && xo[y - 1, x - 1] != "o")
                        {
                            xo[y - 1, x - 1] = "x";
                            i++;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Wrong coordinats");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong coordinats");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong coordinats");
                }
            } 
           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {


                    Console.Write($"{xo[i, j]}");


                }
                Console.WriteLine();
            }
            if (xo[0, 0] == "x" && xo[1, 0] == "x" && xo[2, 0] == "x" || xo[0, 1] == "x" && xo[1, 1] == "x" && xo[2, 1] == "x" || xo[0, 2] == "x" && xo[1, 2] == "x" && xo[2, 2] == "x" || xo[0, 0] == "x" && xo[0, 1] == "x" && xo[0, 2] == "x" || xo[1, 0] == "x" && xo[1, 1] == "x" && xo[1, 2] == "x" || xo[2, 0] == "x" && xo[2, 1] == "x" && xo[2, 2] == "x" || xo[0, 0] == "x" && xo[1, 1] == "x" && xo[2, 2] == "x" || xo[0, 2] == "x" && xo[1, 1] == "x" && xo[2, 0] == "x")
            {

                Console.WriteLine($"\nP1-WIN");
                game = false;
            }
           
            
            else if (game == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {


                        if (xo[i, j] == "x" || xo[i, j] == "o")
                        {
                            g++;
                        }
                        if (g >= 9)
                        {
                            game = false;
                           
                            
                            Console.WriteLine($"\nDraw");
                        }

                    }

                }
                
                if (g < 9)
                {
                    Console.WriteLine($"\nP2-Turn");
                    for (int i = 0; i < 1;)
                    {
                        Console.Write("x:");
                        if (int.TryParse(Console.ReadLine(), out var x))
                        {
                            Console.Write("y:");
                            if (int.TryParse(Console.ReadLine(), out var y))
                            {
                                if (y > 0 && y < 4 && x > 0 && x < 4 && xo[y - 1, x - 1] != "x" && xo[y - 1, x - 1] != "o")
                                {
                                    xo[y - 1, x - 1] = "o";
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Wrong coordinats");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong coordinats");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong coordinats");
                        }
                    }
                }
              
                if (xo[0, 0] == "o" && xo[1, 0] == "o" && xo[2, 0] == "o" || xo[0, 1] == "o" && xo[1, 1] == "o" && xo[2, 1] == "o" || xo[0, 2] == "o" && xo[1, 2] == "o" && xo[2, 2] == "o" || xo[0, 0] == "o" && xo[0, 1] == "o" && xo[0, 2] == "o" || xo[1, 0] == "o" && xo[1, 1] == "o" && xo[1, 2] == "o" || xo[2, 0] == "o" && xo[2, 1] == "o" && xo[2, 2] == "o" || xo[0, 0] == "o" && xo[1, 1] == "o" && xo[2, 2] == "o" || xo[0, 2] == "o" && xo[1, 1] == "o" && xo[2, 0] == "o")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {


                            Console.Write($"{xo[i, j]}");


                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"\nP2-WIN");
                    game = false;
                }
                g = 0;



               
                   
                   
            
               
              
            
            
            }
           
        }
   
    }
}