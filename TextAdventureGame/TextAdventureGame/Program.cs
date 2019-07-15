using System;

namespace TextAdventureGame
{
    class Program
    {

        static void printTemple(char[,] mat)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(0); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            char[,] matrix = new char[9, 9];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = '0';
                }
            }

            Console.WriteLine("TEXT ADVENTURE \n_____________");
            char position = 'X';
            int x = 4; int y = 4;
            matrix[x, y] = position;
            bool key = false;
            Console.WriteLine("You wake up in a 9x9 temple, try to go through it and find the key to open the exit door.\n Good luck!");

            while (true)
            {
                Console.Clear();
                printTemple(matrix);
                Console.WriteLine("W up, A left, D right, S down");
                Console.WriteLine("Choose where you want to go: ");
                try
                {
                    string input = Console.ReadLine();
                    input = input.ToUpper();
                    if (input.Equals("W"))
                    {
                        matrix[x, y] = '0';
                        x--;
                        matrix[x, y] = position;
                    }
                    else if (input.Equals("A"))
                    {
                        matrix[x, y] = '0';
                        y--;
                        matrix[x, y] = position;
                    }
                    else if (input.Equals("D"))
                    {
                        matrix[x, y] = '0';
                        y++;
                        matrix[x, y] = position;
                    }
                    else if (input.Equals("S"))
                    {
                        matrix[x, y] = '0';
                        x++;
                        matrix[x, y] = position;
                    }
                }
                catch
                {
                    Console.WriteLine("You walked into a wall and hit your head.");
                    Console.WriteLine("GAME OVER");
                    System.Environment.Exit(0);
                }
                if ((x == 3) && (y == 4))
                {
                    Console.WriteLine("YOU FOUND A ROOM SAYING KEY UP NORTH");
                }
                else if ((x == 2) && (y == 4))
                {
                    Console.WriteLine("YOU FOUND A CHEST. OPEN IT?");
                    Console.WriteLine("O to open.");
                    string trap = Console.ReadLine();
                    trap = trap.ToUpper();
                    if (trap.Equals("O"))
                    {
                        Console.WriteLine("YOU FOUND A SNAKE!");
                        Console.WriteLine("GAME OVER!");
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if ((x == 4) && (y == 5))
                {
                    Console.WriteLine("YOU FOUND A DARK ROOM.");
                }
                else if ((x == 4) && (y == 6))
                {
                    if (key == true)
                    {
                        Console.WriteLine("You got the key.");

                    }
                    else
                    {
                        Console.WriteLine("YOU FOUND A KEY!");
                        Console.WriteLine("Pick it up?");
                        string input = Console.ReadLine();
                        input = input.ToUpper();
                        Console.WriteLine("P to pick it up.");
                        if (input.Equals("P"))
                        {
                            Console.WriteLine("YOU GOT THE KEY!");
                            key = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if ((x == 0) && (y == 0))
                {
                    Console.WriteLine("YOU FOUND THE EXIT.");
                    if (key == true)
                    {
                        Console.WriteLine("You have the key!");
                        Console.WriteLine("You escaped the temple!");
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You can escape but your key is missing...");
                    }
                }
                else
                {
                    Console.WriteLine("You found nothing but dust and cobwebs.");
                }
            }
        }
    }
}
