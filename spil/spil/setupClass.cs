using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class setupClass
    {
        gameClass setupPlayer { get; set; }

        Player1 gameBoard_1 { get; set; }

        Player2 gameBoard_2 { get; set; }
        public void Hangarskib_1()
        {
            
            Console.WriteLine("Vil du sætte dit hangarskib lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dit første hangarskib?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 6)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Hangarskib_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X + 2, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X + 3, Y - 1] = 'H';

            } else if (x == 2)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 6)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Hangarskib_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y + 2] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y + 3] = 'H';
            }
            else
            {
                Console.WriteLine("Try Again");
            }

            
        }
        public void Slagskib_1()
        {

            Console.WriteLine("Vil du sætte dit Slagskib lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");
            
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hvor vil du sætte dine Slagskibe?");

                if (x == 1)
                {
                    //vandret
                    Console.WriteLine("Skriv X værdi");
                    int X = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Skriv Y værdi");
                    int Y = Convert.ToInt32(Console.ReadLine());

                    if (X >= 7)
                    {
                        Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                        Slagskib_1();
                    }

                    gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'S';
                    gameBoard_1.YoureGameBoard[X, Y - 1] = 'S';
                    gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'S';
                    gameBoard_1.YoureGameBoard[X + 2, Y - 1] = 'S';
                    
                }
                else if (x == 2)
                {
                //Lodret
                    Console.WriteLine("Skriv X værdi");
                    int X = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Skriv Y værdi");
                    int Y = Convert.ToInt32(Console.ReadLine());

                    if (Y >= 7)
                    {
                        Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                        Slagskib_1();
                    }

                    gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'S';
                    gameBoard_1.YoureGameBoard[X - 1, Y] = 'S';
                    gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'S';
                    gameBoard_1.YoureGameBoard[X - 1, Y + 2] = 'S';
                    
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
             

        }
        public void Destroyer_1()
        {

            Console.WriteLine("Vil du sætte dit Destroyer lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dine Destroyer?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Destroyer_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'D';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'D';
                gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'D';

            }
            else if (x == 2)
            {
                //Lodret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Destroyer_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'D';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'D';
                gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'D';

            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }
        public void Ubåd_1()
        {

            Console.WriteLine("Vil du sætte dit Ubåd lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dine Ubåd?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Ubåd_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'U';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'U';
                gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'U';

            }
            else if (x == 2)
            {
                //Lodret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Ubåd_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'U';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'U';
                gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'U';

            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }
        public void Patruljebåd_1()
        {

            Console.WriteLine("Vil du sætte dit Patruljebåd lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dine Patruljebåd?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 9)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Patruljebåd_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'P';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'P';

            }
            else if (x == 2)
            {
                //Lodret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 9)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Patruljebåd_1();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'P';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'P';


            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }


        public void Hangarskib_2()
        {

            Console.WriteLine("Vil du sætte dit hangarskib lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dit første hangarskib?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 6)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Hangarskib_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X + 2, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X + 3, Y - 1] = 'H';

            }
            else if (x == 2)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 6)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Hangarskib_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y + 2] = 'H';
                gameBoard_1.YoureGameBoard[X - 1, Y + 3] = 'H';
            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }
        public void Slagskib_2()
        {

            Console.WriteLine("Vil du sætte dit Slagskib lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dine Slagskibe?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 7)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Slagskib_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'S';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'S';
                gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'S';
                gameBoard_1.YoureGameBoard[X + 2, Y - 1] = 'S';

            }
            else if (x == 2)
            {
                //Lodret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 7)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Slagskib_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'S';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'S';
                gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'S';
                gameBoard_1.YoureGameBoard[X - 1, Y + 2] = 'S';

            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }
        public void Destroyer_2()
        {

            Console.WriteLine("Vil du sætte dit Destroyer lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dine Destroyer?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Destroyer_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'D';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'D';
                gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'D';

            }
            else if (x == 2)
            {
                //Lodret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Destroyer_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'D';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'D';
                gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'D';

            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }
        public void Ubåd_2()
        {

            Console.WriteLine("Vil du sætte dit Ubåd lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dine Ubåd?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Ubåd_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'U';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'U';
                gameBoard_1.YoureGameBoard[X + 1, Y - 1] = 'U';

            }
            else if (x == 2)
            {
                //Lodret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 8)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Ubåd_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'U';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'U';
                gameBoard_1.YoureGameBoard[X - 1, Y + 1] = 'U';

            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }
        public void Patruljebåd_2()
        {

            Console.WriteLine("Vil du sætte dit Patruljebåd lodret eller vandret?");
            Console.WriteLine("1) For Vandret");
            Console.WriteLine("2) For Lodret");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor vil du sætte dine Patruljebåd?");

            if (x == 1)
            {
                //vandret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (X >= 9)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Patruljebåd_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'P';
                gameBoard_1.YoureGameBoard[X, Y - 1] = 'P';

            }
            else if (x == 2)
            {
                //Lodret
                Console.WriteLine("Skriv X værdi");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv Y værdi");
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= 9)
                {
                    Console.WriteLine("Try Again Y Value Can't Be 10 or higher");
                    Patruljebåd_2();
                }

                gameBoard_1.YoureGameBoard[X - 1, Y - 1] = 'P';
                gameBoard_1.YoureGameBoard[X - 1, Y] = 'P';


            }
            else
            {
                Console.WriteLine("Try Again");
            }


        }


        public void setupPlayer_1()
        {
            setupPlayer = new gameClass();

            Hangarskib_1();

            setupPlayer.ShowMenu();

            int antal = 0;
            do
            {
                Slagskib_1();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 2);

            setupPlayer.ShowMenu();

            if (antal < 2)
            {
                antal = 0;
            }
            do
            {
                Destroyer_1();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 2);

            setupPlayer.ShowMenu();

            if (antal < 2)

            {
                antal = 0;
            }
            do
            {
                Ubåd_1();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 1);

            setupPlayer.ShowMenu();

            if (antal < 2)

            {
                antal = 0;
            }
            do
            {
                Patruljebåd_1();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 3);


        }

        public void setupPlayer_2()
        {
            setupPlayer = new gameClass();

            Hangarskib_2();

            setupPlayer.ShowMenu();

            int antal = 0;
            do
            {
                Slagskib_2();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 2);

            setupPlayer.ShowMenu();

            if (antal < 2)
            {
                antal = 0;
            }
            do
            {
                Destroyer_2();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 2);

            setupPlayer.ShowMenu();

            if (antal < 2)

            {
                antal = 0;
            }
            do
            {
                Ubåd_2();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 2);

            setupPlayer.ShowMenu();

            if (antal < 2)

            {
                antal = 0;
            }
            do
            {
                Patruljebåd_2();
                setupPlayer.ShowMenu();
                antal++;
            }
            while (antal < 3);


        }


        //public char Boats()
        //{
        //    char Hangarskib = 'H';
        //    char Slagskib = 'S';
        //    char Destroyer = 'D';
        //    char Ubåd = 'U';
        //    char Patruljebåd = 'P';
        //}





    }
}
