using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name?: ");
            string FirstName = Console.ReadLine();
            //What is your first name?-----------------

            Console.Write("What is your last name?: ");
            string LastName = Console.ReadLine();
            //What is your last name-----------------

            Console.Write("What is your age?: ");
            int Age = int.Parse(Console.ReadLine());
            //What is your age?------------


            Console.Write("What month were you born in?: ");
            string BirthMonth = Console.ReadLine();
            //What month?-----------------------

            /*Console.Write("What is your favorite ROYGBIV color?: ");
            string ColorROYGBIV = Console.ReadLine();*/


            ///-------------------------------------------------------------------------------

            Console.Write("What is your favorite ROYGBIV color?: \nEnter \"HELP\" if you do not know what ROYGBIV is: ");
            string ColorROYGBIV = Console.ReadLine();

            string HELP = "HELP";
            if (ColorROYGBIV == HELP)
            {
                Console.WriteLine("ROYGBIV is \nRED, \nORANGE, \nYELLOW, \nGREEN, \nBLUE, \nINDIGO, \nVIOLET");

                Console.Write("\nPlease Enter your favorite color from the list above: ");
                string ColorROYGBIV2 = Console.ReadLine();

                //Console.Write("\nPlease Enter your favorite color from the list above: ");
                //string ColorROYGBIV2 = Console.ReadLine();
                ///may need to change(need make sure this works later for fortune

                //Console.Clear();
            }

            

            /// Fix uppercase and lowercase SHIT
            ////Console.Clear();

            Console.Write("Type the number of siblings you have: ");
            int Siblings = int.Parse(Console.ReadLine());
            ////-------------Siblings



            //------------Section 2--------------

            string retiredate = "";// Retire date used for final fortune


            if (Age % 2 == 0)
            {
                Console.WriteLine("You will retire in 20 years.");
            }
            else
            {
                Console.WriteLine("You will retire in 15 years.");

            }
            ///User's Age will result in Odd or Even numbers--


            string locations = "";
            string siblingsLocations = (locations + Siblings);// Locations used for final fortune
            

            if (Siblings > 3)
            {
                Console.WriteLine(
                    
                    );
            }
            else
            {
                switch (Siblings)
                {
                    case 0:
                        Console.WriteLine("You will live in Punta Cana");
                        break;
                    case 1:
                        Console.WriteLine("You will live in Dakar");
                        break;
                    case 2:
                        Console.WriteLine("You will live in Morrocco");
                        break;
                    case 3:
                        Console.WriteLine("You will live in Wakiki");
                        break;
                }
                ///Places and Locations based of Siblings
                //-----------------------------------------------------------
                //


                
                string transportation = "";// Used for final fortune in the end
                switch(ColorROYGBIV)
                {
                    case "RED":
                        Console.WriteLine("You will have an Aston Martin car");
                        break;
                    case "ORANGE":
                        Console.WriteLine("You will have luxurious yacht");
                        break;
                    case "YELLOW":
                        Console.WriteLine("You will have a G6 plane");
                        break;
                    case "GREEN":
                        Console.WriteLine("You will drive a HoverBoard");
                        break;
                    case "BLUE":
                        Console.WriteLine("You will have a Magic Carpet");
                        break;
                    case "INDIGO":
                        Console.WriteLine("You will be riding on the RTA rapid");
                        break;
                    case "VIOLET":
                        Console.WriteLine("You will have a Harley Davison Bike");
                        break;                       
                }
                ////////--------------------ROGYBIV the first one

                /*switch (ColorROYGBIV)
                {
                    case "RED":
                        Console.WriteLine("You will have an Aston Martin car");
                        break;
                    case "ORANGE":
                        Console.WriteLine("You will have luxurious yacht");
                        break;
                    case "YELLOW":
                        Console.WriteLine("You will have a G6 plane");
                        break;
                    case "GREEN":
                        Console.WriteLine("You will drive a HoverBoard");
                        break;
                    case "BLUE":
                        Console.WriteLine("You will have a Magic Carpet");
                        break;
                    case "INDIGO":
                        Console.WriteLine("You will be riding on the RTA rapid");
                        break;
                    case "VIOLET":
                        Console.WriteLine("You will have a Harley Davison Bike");
                        break; 
                }*/

                string BirthMonthFirstLetter = BirthMonth.Substring(0, 1);
                string BirthMonthSecondLetter = BirthMonth.Substring(1, 2);
                string BirthMonthThirdLetter = BirthMonth.Substring(2, 3);
                //Console.WriteLine(BirthMonthFirstLetter);
                //Console.WriteLine(BirthMonth);
                //-----First Letter of the user's birth month

                //switch (BirthMonthFirstLetter)
                             
                string FullName = (FirstName + LastName);
                string bankTotal = "";

                if (FullName.IndexOf(BirthMonthFirstLetter) != -1)
                {
                    bankTotal = "$20,000";

                }
                else if (FullName.IndexOf(BirthMonthSecondLetter) !=-1)
                {
                    bankTotal = "$20,000";                   
                }

                else if (FullName.IndexOf(BirthMonthThirdLetter) !=-1)
                {
                    bankTotal = "$70,000";
                }

                else
                {
                    bankTotal = "$10,000";
                }

                Console.Write("\n" + FirstName +" " + LastName + " will retire with in " + retiredate + bankTotal + " a vacation home in" + siblingsLocations + "and a "+ transportation );
                                                                                                            
            } 
        }
    }
}
