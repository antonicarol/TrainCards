using System;

namespace TrainCards
{
    class Program
    {
        static Game game = new Game();
        static void Main(string[] args)
        {
          
            WriteInfo();

            StartGame();
      
        }

        static void WriteInfo()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to the Train Cart");
            Console.WriteLine("--------Rules and how to play---------");
            Console.WriteLine("\nYou'll need to complete 5 round all in one game!\n");
            Console.WriteLine("-Round One : ¿Black or Red?\n");
            Console.WriteLine("-Round Two : ¿Higher or Lower?\n");
            Console.WriteLine("-Round Three : ¿Between or Outside?\n"); 
            Console.WriteLine("-Round Four : ¿Is going to Repeat Type?\n");
            Console.WriteLine("-Round Five : ¿Is going to Repeat Card number?\n");
            Console.ResetColor();
        }
        static void StartGame()
        {
            bool x = true;
            
            while (x)
            {
                Console.WriteLine("\n --------Lets Start---------\n ");
                Console.Write("Round One ----- ¿Black or Red (Type 'Red' or ' Black ') : ");
                string chosenColor = Console.ReadLine();

                if (game.RoundOne(chosenColor))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congrats, You passed Round one !");
                    Console.ResetColor();
                    Console.WriteLine("Your Deck : " + game.GetProcess());
                    Console.Write("Round Two ----- ¿Higher or Lower than " + game.GetProcess() +" :  " );
                    string choice = Console.ReadLine();

                    if (game.RoundTwo(choice))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congrats, You passed Round Two !");
                        Console.ResetColor();
                        Console.WriteLine("Your Deck : " + game.GetProcess());
                        Console.Write("Round Two ----- ¿Bettween " + game.GetProcess() + " or Ouside :  ");
                        choice = Console.ReadLine();

                        if (game.RoundThree(choice))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congrats, You passed Round Three !");
                            Console.ResetColor();
                            Console.WriteLine("Your Deck : " + game.GetProcess());
                            Console.Write("Round Two ----- ¿Its going to repeat type? (Yes/No):  ");
                            choice = Console.ReadLine();


                            if (game.RoundFour(choice))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Congrats, You passed Round four !");
                                Console.ResetColor();
                                Console.WriteLine("Your Deck : " + game.GetProcess());
                                Console.Write("Last Round ----- ¿Its going to repeat number? (Yes/No):  ");
                                choice = Console.ReadLine();
                                if (game.RoundFive(choice))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Congrats, You passed Round four !");
                                    Console.ResetColor();
                                    choice = Console.ReadLine();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You failed, try again");
                                    Console.ResetColor();
                                    game.ClearProgress();
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You failed, try again");
                                Console.ResetColor();
                                game.ClearProgress();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You failed, try again");
                            Console.ResetColor();
                            game.ClearProgress();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You failed, try again");
                        Console.ResetColor();
                        game.ClearProgress();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You failed, try again");
                    Console.ResetColor();
                    game.ClearProgress();
                }
            }
            
        }
    }
}
