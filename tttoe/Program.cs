using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
// https://medium.com/@chusto2/tic-tac-toe-for-c-317c1e04b7b3
namespace tttoe
{
    class Program

    {
        //create playfield
        static char[,] playField =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' },
        };

        static int turns = 0;

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |    |      ");
            Console.WriteLine("  {0}  | {1}  |   {2}  ", playField[0, 0], playField[0, 10], playField[0, 2]);
            Console.WriteLine("_____|____|_____ ");
            Console.WriteLine("     |    |      ");
            Console.WriteLine("  {0}  | {1}  |   {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|____|_____ ");
            Console.WriteLine("     |    |      ");
            Console.WriteLine("  {0}  | {1}  |   {2}  ", playField[2, 0], playField[2, 10], playField[2, 2]);
            Console.WriteLine("_____|____|_____ ");
            Console.WriteLine("     |    |      ");
            turns++;

            do

            {
                Console.WriteLine("\nPlayer {0): Choose your field!", player);

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Please enter a number!");
                }

                if (input == 1) && (playField[0, 0] == '1' ))
                        inputCorrect = true;
                else if ((input == 2)) && (playField[0,1] == '2')
                        inputCorrect = true;
                else if ((input == 3)) && (playField[0, 1] == '3')
                        inputCorrect = true;
                else if ((input == 4)) && (playField[0, 1] == '4')
                        inputCorrect = true;
                else if ((input == 5)) && (playField[0, 1] == '5')
                        inputCorrect = true;
                else if ((input == 6)) && (playField[0, 1] == '6')
                        inputCorrect = true;
                else if ((input == 7)) && (playField[0, 1] == '7')
                        inputCorrect = true;
                else if ((input == 8)) && (playField[0, 1] == '8')
                        inputCorrect = true;
                else if ((input == 9)) && (playField[0, 1] == '9')
                        inputCorrect = true;
                else 
                {
                    Console.WriteLine("\nIncorrect input! Please use another field");
                    inputCorrect = false;
                }

            } while (!inputCorrect);

          

        }
         public static void EnterXor0(char playerSign, int input)
            {

                Switch (input)
                {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }

    }

        
    

    }
}
