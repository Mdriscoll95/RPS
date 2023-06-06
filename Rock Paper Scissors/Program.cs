using System;

namespace Rock_Paper_Scissors;
class Program
{
    static void Main(string[] args)
    {
        string inputPlayer, inputCPU;
        int randomInt;

        int scorePlaeyer = 0;
        int scoreCPU = 0;

        bool playAgain = true;
        while (playAgain)
        {

            while (scorePlaeyer < 3 && scoreCPU < 3)
            {



                Console.WriteLine("choose between ROCK, PAPER, and SCISSORS:      ");
                inputPlayer = Console.ReadLine().ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        Console.WriteLine("Computer chose ROCK");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("DRAW!! \n\n ");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlaeyer++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        break;

                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("Computer chose PAPER");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("CPU WINS!! \n\n ");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("DRAW!!\n\n");

                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlaeyer++;

                        }
                        break;

                    case 3:
                        inputCPU = "SCISSORS";
                        Console.WriteLine("Computer chose SCISSORS");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("PLAYER WINS!! \n\n ");
                            scorePlaeyer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("DRAW!!\n\n");
                            scoreCPU++;

                        }
                        break;



                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                        {

                        }

                }
                            Console.WriteLine("\n\nScores: \tPLAYER : \t{0}\tCPU: \t{1}, ", scorePlaeyer, scoreCPU);
            }
                



                if(scorePlaeyer == 3)
                {
                    Console.WriteLine("Player Wins!!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WIN!!!!");
                }
                
                    Console.WriteLine("Do you want to play again (y/n)");
                    string loop = Console.ReadLine();
                    if(loop == "y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if(loop == "n")
                    {
                        playAgain = false;
                    }

            scorePlaeyer = 0;
            scoreCPU = 0;

                   
                

        }
    }
}

