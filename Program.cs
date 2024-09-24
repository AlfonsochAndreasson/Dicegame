namespace Dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to a scuffed dice game");
                Console.WriteLine("You have 5000$ dollars");
                int Money = 5000;

                
                Console.WriteLine("How much do you wanna bet?");
                int BetAmount = int.Parse(Console.ReadLine());

                if (BetAmount > Money)
                {
                    Console.WriteLine("We do not support fraudulent activites");
                    break;
                }

                Console.WriteLine("Say bet to start");

                string answer = Console.ReadLine();

                int playerScore = 0;
                int dealerScore = 0;

                while (answer == "bet")
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(1, 7);
                    Console.WriteLine("you rolled " + randomNumber);
                    playerScore += randomNumber;


                    Random randDealer = new Random();
                    int randomNumberDealer = randDealer.Next(1, 7);
                    Console.WriteLine("Dealer rolled " + randomNumberDealer);
                    dealerScore += randomNumberDealer;

                    Console.WriteLine("Your score is " + playerScore);
                    Console.WriteLine("Dealer score is " + dealerScore);

                    if (playerScore == 21)
                    {
                        Console.WriteLine("you win");
                        Console.WriteLine("you have won " + BetAmount * 2 + " Dollars");
                        break;
                    }
                    else if (dealerScore == 21)
                    {
                        Console.WriteLine("Dealer wins");
                        Console.WriteLine("you have lost " + BetAmount + " Dollars");
                        break;
                    }
                    else if (playerScore > 21 && dealerScore < 21)
                    {
                        Console.WriteLine("Dealer wins");
                        Console.WriteLine("you have lost " + BetAmount + " Dollars");
                       
                        break;
                    }
                    else if (dealerScore > 21 && playerScore < 21)
                    {
                        Console.WriteLine("Player wins");
                        Console.WriteLine("you have won " + BetAmount * 2 + " Dollars");
                        break;
                    }
                    else if (playerScore == 21 && dealerScore == 21)
                    {
                        Console.WriteLine("Dealer wins");
                        Console.WriteLine("you have lost " + BetAmount + " Dollars"); 

                        break;

                    }

                    Console.WriteLine("bet or stay  \r\n ");
                    answer = Console.ReadLine();

                    if (answer == "stay")
                    {
                        Console.WriteLine("Your final score is " + playerScore);
                        Console.WriteLine("Dealer final score is " + dealerScore);

                        if (playerScore > dealerScore)
                        {
                            Console.WriteLine("Player wins");
                            Console.WriteLine("you have won " + BetAmount * 2 + " Dollars");
                            break;
                        }
                        else if (dealerScore > playerScore)
                        {
                            Console.WriteLine("Dealer wins");
                            Console.WriteLine("you have lost " + BetAmount + " Dollars");
                            break;
                        }


                    }

                    
                }
                Console.WriteLine("Do you wanna play again? \r\n ");
                string answer2 = Console.ReadLine();
                if (answer2 == "No" || answer2 == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
              
               
            }
            {
                
                
            }

        }
    }
}
