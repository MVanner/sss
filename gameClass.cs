using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class gameClass
    {
        setupClass setupPlayers { get; set; }
        Player1 gameBoard_1 { get; set; }
        Player2 gameBoard_2 { get; set; }

        public void Show()
        {
            bool running = true;
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    //case "2": DoActionFor2(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }
        public void ShowMenu()
        {
            Console.Clear();
            if (gameBoard_1 != null)
            {
                Console.WriteLine(gameBoard_1.GetGameBoardView());
            }
            else if (gameBoard_2 != null)
            {
                Console.WriteLine(gameBoard_2.GetGameBoardView());
            }
            Console.WriteLine("Sænke Slagskib");
            Console.WriteLine();
            Console.WriteLine("1. Opret nyt spil");
           // Console.WriteLine("2. Sæt skibe");
            Console.WriteLine();
            Console.WriteLine("0. exit");
        }
        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShowMenuSelectionErroe()
        {
            throw new NotImplementedException();
        }

        private void DoActionFor1()
        {
            gameBoard_1 = new Player1();
            Console.WriteLine("Player 1 Sætter Sine Skibe :D\n");
            setupPlayers.setupPlayer_1();

            Console.Clear();
            Console.WriteLine("Skrift spiller og tryk for at spller 2 sætter sit lort");
            Console.ReadLine();

            gameBoard_2 = new Player2();
            Console.WriteLine("Player 2 Sætter Sine Skibe :D\n");
            setupPlayers.setupPlayer_2();

            NyMenu();

        }

        private void NyMenu()
        {

        }
        //private void DoActionFor2()
        //{

           


        //}



    }
}
