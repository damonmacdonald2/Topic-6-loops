using System.Security.Cryptography.X509Certificates;

namespace Topic_6_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Ethan's magical menu! Please type the number of the option you would like!");
                Console.WriteLine();
                Console.WriteLine("1) Prompter");
                Console.WriteLine("2) Percent Passing");
                Console.WriteLine("3) Odd Sum");
                Console.WriteLine("4) Random Numbers");
                Console.WriteLine("5) Dice Game");
                Console.WriteLine("6) Quit");
                Console.WriteLine();
                choice = Console.ReadLine().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    prompter();
                }
                else if (choice == "2")
                {
                    percentPassing();
                }
                else if (choice == "3")
                {
                    oddSum();
                }
                else if (choice == "4")
                {
                    randomNumbers();
                }
                else if (choice == "5")
                {
                    diceGame();
                }
                else if (choice == null)
                {
                    Console.WriteLine("Please enter an option from 1-6!");
                    choice = Console.ReadLine().Trim();
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
           
        }
        public static void prompter()
        {
            double min, max, numberChoice;
            Console.WriteLine("Please enter 2 numbers, the first will be the minimum, the second will be the maximum!");
            Console.WriteLine("Please enter the minimum");
            min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the maximum");
            max = Convert.ToDouble(Console.ReadLine());
            if (min > max)
            {
                Console.WriteLine("The FIRST number needs to be SMALLER than the SECOND");
                Console.WriteLine("Please enter the minimum");
                min = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the maximum");
                max = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Ok so your minimum is " + min + " and your max is " + max + "! Now I need you to enter a number between those two values!");
            numberChoice = Convert.ToDouble(Console.ReadLine());
            if (numberChoice> min && numberChoice< max)
            {
                Console.WriteLine("You chose " + numberChoice + " that is between " + min + " and " + max + "!");
                Console.WriteLine("press ENTER to continue.");
                Console.ReadLine();
            }
            else if (numberChoice <= min || numberChoice >= max) 
            {
                bool done = false;
                while (!done)
                {
                    Console.WriteLine(numberChoice + " is not between " + min + " and " + max + "! Please try again");
                    numberChoice = Convert.ToDouble(Console.ReadLine());
                    if (numberChoice > min && numberChoice < max)
                    {
                        Console.WriteLine("You chose " + numberChoice + " that is between " + min + " and " + max + "!");
                        Console.WriteLine("press ENTER to continue.");
                        done = true;
                        Console.ReadLine();
                    }
                }
            }
            
        }
        public static void percentPassing()
        {
            double over70=0;
            string percentage;
            bool done = false;
            double totalPercentages=0;
            string close;
            Console.WriteLine("Please enter all of the grades you have collected! I will tell you how many are over 70%");

            while (!done)
            {
                Console.WriteLine("Enter each number or a 'Q' to stop typing numbers!");
                percentage = Console.ReadLine().ToUpper();
                if (percentage == "Q")
                {
                    Console.WriteLine(Math.Round(over70 / totalPercentages * 100, 1) + "% of your numbers were over 70");
                    Console.WriteLine("Press ENTER to continue!");
                    done = true;
                    close = Console.ReadLine();
                    if (close == null)
                    {
                        done = true;
                    }
                }
                else
                {
                    totalPercentages++;
                    if (Convert.ToDouble(percentage)>= 70)
                    {
                        over70++;
                    }
                }
                

            }
        }
        public static void oddSum()
        {
            int oddNumber;
            int addition = 0;
            Console.WriteLine("Please give me a number and I will add up all previous odd numbers before it!");
            oddNumber = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i < oddNumber; i+=2) 
            {
                addition+= i;
            }
            Console.WriteLine("Your total of all the previous odd numbers before " + oddNumber + " is " + addition);
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
        public static void randomNumbers()
        {
            Random generator = new Random();
            int min, max, randomNumber;
            bool done = false;
            string close;
            Console.WriteLine("Can you give me two numbers the first will be the minimum! Please enter the minimum number!");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the maximum! Maker sure this number is greater than the minimum number!");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your numbers are");
            while (!done)
            {


                if (max < min)
                {
                    Console.WriteLine("The second number has to be bigger than the first one!");
                    Console.WriteLine("Can you give me two numbers the first will be the minimum! Please enter the minimum number!");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the maximum! Maker sure this number is greater than the minimum number!");
                    max = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your numbers are");
                }
                else
                {
                    Console.WriteLine("Your numbers are");
                }
                for (int i = 0; i < 25; i++)
                {
                    randomNumber = generator.Next(min, max + 1);
                    Console.WriteLine(":" + randomNumber);

                }
                Console.WriteLine("Press ENTER to continue!");
                close= Console.ReadLine();
                done = true;
                
            }
        }
        public static void diceGame()
        {
            string answer, keepPlaying;
            double balance = 100, bet;
            bool done;
            Die dieOne;
            Die dieTwo;
            dieOne = new Die();
            dieTwo = new Die();

            Console.WriteLine("Welcome to Ethan's Casino! What game would you like to play? Sike doesn't matter he makes you bet on the outcome of two die... So what would you like to bet on?");
            done = false;
            while (!done)
            {
                Console.WriteLine("A)Double \nB)Not Double \nC)Odd \nD)Even \nPlease type the letter of the bet you want! ");
                answer = Console.ReadLine().ToLower();
                Console.WriteLine("How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                if (bet > balance)
                {
                    Console.WriteLine("You don't have that much to bet please try again!");
                    bet = Convert.ToInt32(Console.ReadLine());

                }
                if (answer == "a")
                {
                    Console.WriteLine("You're betting $" + bet + " on doubles! Let's see if your lucky or not.");
                    dieOne.RollDie();
                    Console.WriteLine(dieOne);
                    dieOne.DrawRoll();
                    dieTwo.RollDie();
                    Console.WriteLine(dieTwo);
                    dieTwo.DrawRoll();
                    if (dieOne.Roll != dieTwo.Roll)
                    {
                        balance = balance - bet;
                        Console.WriteLine("You Lost your bet... You now have $" + balance);
                    }
                    else if (dieTwo.Roll == dieOne.Roll)
                    {
                        balance = balance + (2 * bet);
                        Console.WriteLine("You won!! You now have $" + balance);
                    }

                }
                if (answer == "b")
                {
                    Console.WriteLine("You're betting $" + bet + " on not doubles! Let's see if your lucky or not.");
                    dieOne.RollDie();
                    Console.WriteLine(dieOne);
                    dieOne.DrawRoll();
                    dieTwo.RollDie();
                    Console.WriteLine(dieTwo);
                    dieTwo.DrawRoll();
                    if (dieOne.Roll == dieTwo.Roll)
                    {
                        balance = balance - bet;
                        Console.WriteLine("You Lost your bet... You now have $" + balance);
                    }
                    else if (dieTwo.Roll != dieOne.Roll)
                    {
                        balance = balance + (.5 * bet);
                        Console.WriteLine("You won!! You now have $" + balance);
                    }

                }
                if (answer == "c")
                {
                    Console.WriteLine("You're betting $" + bet + " on Odds! Let's see if your lucky or not.");
                    dieOne.RollDie();
                    Console.WriteLine(dieOne);
                    dieOne.DrawRoll();
                    dieTwo.RollDie();
                    Console.WriteLine(dieTwo);
                    dieTwo.DrawRoll();
                    if (dieOne.Roll + dieTwo.Roll == 2 || dieOne.Roll + dieTwo.Roll == 4 || dieOne.Roll + dieTwo.Roll == 6 || dieOne.Roll + dieTwo.Roll == 8 || dieOne.Roll + dieTwo.Roll == 10 || dieOne.Roll + dieTwo.Roll == 12)
                    {
                        Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an even number sorry!");
                        balance = balance - bet;
                        Console.WriteLine("You Lost your bet... You now have $" + balance);
                    }
                    else if (dieOne.Roll + dieTwo.Roll == 3 || dieOne.Roll + dieTwo.Roll == 5 || dieOne.Roll + dieTwo.Roll == 7 || dieOne.Roll + dieTwo.Roll == 9 || dieOne.Roll + dieTwo.Roll == 11)
                    {
                        Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an odd number congrats!");
                        balance = balance + bet;
                        Console.WriteLine("You won!! You now have $" + balance);
                    }

                }
                if (answer == "d")
                {
                    Console.WriteLine("You're betting $" + bet + " on Evens! Let's see if your lucky or not.");
                    dieOne.RollDie();
                    Console.WriteLine(dieOne);
                    dieOne.DrawRoll();
                    dieTwo.RollDie();
                    Console.WriteLine(dieTwo);
                    dieTwo.DrawRoll();
                    if (dieOne.Roll + dieTwo.Roll == 2 || dieOne.Roll + dieTwo.Roll == 4 || dieOne.Roll + dieTwo.Roll == 6 || dieOne.Roll + dieTwo.Roll == 8 || dieOne.Roll + dieTwo.Roll == 10 || dieOne.Roll + dieTwo.Roll == 12)
                    {
                        Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an even number congrats!");
                        balance = balance + bet;
                        Console.WriteLine("You won!! You now have $" + balance);
                    }
                    else if (dieOne.Roll + dieTwo.Roll == 3 || dieOne.Roll + dieTwo.Roll == 5 || dieOne.Roll + dieTwo.Roll == 7 || dieOne.Roll + dieTwo.Roll == 9 || dieOne.Roll + dieTwo.Roll == 11)
                    {
                        Console.WriteLine("The outcome was " + (dieOne.Roll + dieTwo.Roll) + " which is an odd number sorry!");
                        balance = balance - bet;
                        Console.WriteLine("You Lost your bet... You now have $" + balance);
                    }

                }
                Console.WriteLine("Would you like to play again?");
                keepPlaying = Console.ReadLine().ToLower();
                if (keepPlaying == "yes")
                {
                    Console.WriteLine("You have $" + balance);
                    done = false;
                    
                }
                else if (keepPlaying == "no")
                {
                    return;
                }
                
            }
        }
    }
}