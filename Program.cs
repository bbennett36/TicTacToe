using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.run();
            

        }

        public static void run()
        {
            int choiceCount = 0;
            List<String> used = new List<String>();


            Console.Write("Enter Name for Player 1: ");
            String name1 = Console.ReadLine();

            Console.Write("Enter Name for Player 2: ");
            String name2 = Console.ReadLine();

            String one = "1";
            String two = "2";
            String three = "3";
            String four = "4";
            String five = "5";
            String six = "6";
            String seven = "7";
            String eight = "8";
            String nine = "9";


            Program.display(one,two,three,four,five,six,seven,eight,nine);

            String winner = "";
            while (winner.Equals(""))
            {

                String choice = Program.Choice(name1, used);
                

                switch (choice)
                {
                    case "1":
                        one = "X";
                        break;
                    case "2":
                        two = "X";
                        break;
                    case "3":
                        three = "X";
                        break;
                    case "4":
                        four = "X";
                        break;
                    case "5":
                        five = "X";
                        break;
                    case "6":
                        six = "X";
                        break;
                    case "7":
                        seven = "X";
                        break;
                    case "8":
                        eight = "X";
                        break;
                    case "9":
                        nine = "X";
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Program.display(one, two, three, four, five, six, seven, eight, nine);

                if (one.Equals("X") && two.Equals("X") && three.Equals("X") || 
                    one.Equals("X") && four.Equals("X") && seven.Equals("X") || 
                    one.Equals("X") && five.Equals("X") && nine.Equals("X") ||
                    two.Equals("X") && five.Equals("X") && eight.Equals("X") ||
                    three.Equals("X") && five.Equals("X") && seven.Equals("X") ||
                    three.Equals("X") && six.Equals("X") && nine.Equals("X") ||
                    four.Equals("X") && five.Equals("X") && six.Equals("X") ||
                    seven.Equals("X") && eight.Equals("X") && nine.Equals("X"))
                {
                    winner = ("Winner is " + name1);
                    Console.WriteLine(winner);
                    Console.WriteLine("Thank you for playing!");
                    break;
                }

                choiceCount++;
                if (choiceCount == 9)
                {
                    winner = ("Tie Game!");
                    Console.WriteLine(winner);
                    Console.WriteLine("Thank you for playing!");
                    break;
                }

                
                String choice2 = Program.Choice(name2, used);

                switch (choice2)
                {
                    case "1":
                        one = "O";
                        break;
                    case "2":
                        two = "O";
                        break;
                    case "3":
                        three = "O";
                        break;
                    case "4":
                        four = "O";
                        break;
                    case "5":
                        five = "O";
                        break;
                    case "6":
                        six = "O";
                        break;
                    case "7":
                        seven = "O";
                        break;
                    case "8":
                        eight = "O";
                        break;
                    case "9":
                        nine = "O";
                        break;
                    default:
                        Console.WriteLine("Ivnalid choice");
                        break;
                }

                choiceCount++;
                Program.display(one, two, three, four, five, six, seven, eight, nine);

                if (one.Equals("O") && two.Equals("O") && three.Equals("O") ||
                   one.Equals("O") && four.Equals("O") && seven.Equals("O") ||
                   one.Equals("O") && five.Equals("O") && nine.Equals("O") ||
                   two.Equals("O") && five.Equals("O") && eight.Equals("O") ||
                   three.Equals("O") && five.Equals("O") && seven.Equals("O") ||
                   three.Equals("O") && six.Equals("O") && nine.Equals("O") ||
                   four.Equals("O") && five.Equals("O") && six.Equals("O") ||
                   seven.Equals("O") && eight.Equals("O") && nine.Equals("O"))
                {
                    winner = ("Winner is " + name2);
                    Console.WriteLine(winner);
                    Console.WriteLine("Thank you for playing!");
                    break;
                }

               

            }

        }

        public static String Choice(String name,List<String> used)
        {
            Console.Write(name + " Please type the number for the location you choose: ");
            String choice = Console.ReadLine();

            used.Add(choice);

            bool isRepeated = used.Count(x => x == choice) > 1;

            while(isRepeated == true)
            {
                Console.WriteLine("This location was already selected, please try again");
                choice = Console.ReadLine();
                isRepeated = used.Count(x => x == choice) > 1;
            }

           
            return choice;
        }

        public static void display(String one, String two, String three, String four, String five, String six, String seven, String eight, String nine)
        {
            Console.WriteLine("      |     |              ");
            Console.WriteLine("   " + one + "  |  " + two + "  |   " + three + "  ");
            Console.WriteLine("      |     |              ");
            Console.WriteLine("------------------");
            Console.WriteLine("      |     |              ");
            Console.WriteLine("   " + four + "  |  " + five + "  |   " + six + "  ");
            Console.WriteLine("      |     |              ");
            Console.WriteLine("------------------");
            Console.WriteLine("      |     |              ");
            Console.WriteLine("   " + seven + "  |  " + eight + "  |   " + nine + "  ");
            Console.WriteLine("      |     |              ");
        }



        }



    }

