using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Player1
    {
        public char[,] YoureGameBoard
        {
            get;
            set;
        }
        public char[,] EnemysGameBoard { get; set; }

        public Player1()

        {
            YoureGameBoard = new char[10, 10]
            {

                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'}
            };

            EnemysGameBoard = new char[10, 10]
            {
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'},
                {'~','~','~','~','~','~','~','~','~','~'}
            };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "\n";
            resultat = resultat + "     1   2   3   4   5   6   7   8   9   10" + "     |   "; resultat = resultat + "     1   2   3   4   5   6   7   8   9   10\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 1 | " + YoureGameBoard[0, 0] + " | " + YoureGameBoard[1, 0] + " | " + YoureGameBoard[2, 0] + " | " + YoureGameBoard[3, 0] + " | " + YoureGameBoard[4, 0] + " | " + YoureGameBoard[5, 0] + " | " + YoureGameBoard[6, 0] + " | " + YoureGameBoard[7, 0] + " | " + YoureGameBoard[8, 0] + " | " + YoureGameBoard[9, 0] + " |    |   "; resultat = resultat + " 1 | " + EnemysGameBoard[0, 0] + " | " + EnemysGameBoard[1, 0] + " | " + EnemysGameBoard[2, 0] + " | " + EnemysGameBoard[3, 0] + " | " + EnemysGameBoard[4, 0] + " | " + EnemysGameBoard[5, 0] + " | " + EnemysGameBoard[6, 0] + " | " + EnemysGameBoard[7, 0] + " | " + EnemysGameBoard[8, 0] + " | " + EnemysGameBoard[9, 0] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 2 | " + YoureGameBoard[0, 1] + " | " + YoureGameBoard[1, 1] + " | " + YoureGameBoard[2, 1] + " | " + YoureGameBoard[3, 1] + " | " + YoureGameBoard[4, 1] + " | " + YoureGameBoard[5, 1] + " | " + YoureGameBoard[6, 1] + " | " + YoureGameBoard[7, 1] + " | " + YoureGameBoard[8, 1] + " | " + YoureGameBoard[9, 1] + " |    |   "; resultat = resultat + " 2 | " + EnemysGameBoard[0, 1] + " | " + EnemysGameBoard[1, 1] + " | " + EnemysGameBoard[2, 1] + " | " + EnemysGameBoard[3, 1] + " | " + EnemysGameBoard[4, 1] + " | " + EnemysGameBoard[5, 1] + " | " + EnemysGameBoard[6, 1] + " | " + EnemysGameBoard[7, 1] + " | " + EnemysGameBoard[8, 1] + " | " + EnemysGameBoard[9, 1] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 3 | " + YoureGameBoard[0, 2] + " | " + YoureGameBoard[1, 2] + " | " + YoureGameBoard[2, 2] + " | " + YoureGameBoard[3, 2] + " | " + YoureGameBoard[4, 2] + " | " + YoureGameBoard[5, 2] + " | " + YoureGameBoard[6, 2] + " | " + YoureGameBoard[7, 2] + " | " + YoureGameBoard[8, 2] + " | " + YoureGameBoard[9, 2] + " |    |   "; resultat = resultat + " 3 | " + EnemysGameBoard[0, 2] + " | " + EnemysGameBoard[1, 2] + " | " + EnemysGameBoard[2, 2] + " | " + EnemysGameBoard[3, 2] + " | " + EnemysGameBoard[4, 2] + " | " + EnemysGameBoard[5, 2] + " | " + EnemysGameBoard[6, 2] + " | " + EnemysGameBoard[7, 2] + " | " + EnemysGameBoard[8, 2] + " | " + EnemysGameBoard[9, 2] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 4 | " + YoureGameBoard[0, 3] + " | " + YoureGameBoard[1, 3] + " | " + YoureGameBoard[2, 3] + " | " + YoureGameBoard[3, 3] + " | " + YoureGameBoard[4, 3] + " | " + YoureGameBoard[5, 3] + " | " + YoureGameBoard[6, 3] + " | " + YoureGameBoard[7, 3] + " | " + YoureGameBoard[8, 3] + " | " + YoureGameBoard[9, 3] + " |    |   "; resultat = resultat + " 4 | " + EnemysGameBoard[0, 3] + " | " + EnemysGameBoard[1, 3] + " | " + EnemysGameBoard[2, 3] + " | " + EnemysGameBoard[3, 3] + " | " + EnemysGameBoard[4, 3] + " | " + EnemysGameBoard[5, 3] + " | " + EnemysGameBoard[6, 3] + " | " + EnemysGameBoard[7, 3] + " | " + EnemysGameBoard[8, 3] + " | " + EnemysGameBoard[9, 3] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 5 | " + YoureGameBoard[0, 4] + " | " + YoureGameBoard[1, 4] + " | " + YoureGameBoard[2, 4] + " | " + YoureGameBoard[3, 4] + " | " + YoureGameBoard[4, 4] + " | " + YoureGameBoard[5, 4] + " | " + YoureGameBoard[6, 4] + " | " + YoureGameBoard[7, 4] + " | " + YoureGameBoard[8, 4] + " | " + YoureGameBoard[9, 4] + " |    |   "; resultat = resultat + " 5 | " + EnemysGameBoard[0, 4] + " | " + EnemysGameBoard[1, 4] + " | " + EnemysGameBoard[2, 4] + " | " + EnemysGameBoard[3, 4] + " | " + EnemysGameBoard[4, 4] + " | " + EnemysGameBoard[5, 4] + " | " + EnemysGameBoard[6, 4] + " | " + EnemysGameBoard[7, 4] + " | " + EnemysGameBoard[8, 4] + " | " + EnemysGameBoard[9, 4] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 6 | " + YoureGameBoard[0, 5] + " | " + YoureGameBoard[1, 5] + " | " + YoureGameBoard[2, 5] + " | " + YoureGameBoard[3, 5] + " | " + YoureGameBoard[4, 5] + " | " + YoureGameBoard[5, 5] + " | " + YoureGameBoard[6, 5] + " | " + YoureGameBoard[7, 5] + " | " + YoureGameBoard[8, 5] + " | " + YoureGameBoard[9, 5] + " |    |   "; resultat = resultat + " 6 | " + EnemysGameBoard[0, 5] + " | " + EnemysGameBoard[1, 5] + " | " + EnemysGameBoard[2, 5] + " | " + EnemysGameBoard[3, 5] + " | " + EnemysGameBoard[4, 5] + " | " + EnemysGameBoard[5, 5] + " | " + EnemysGameBoard[6, 5] + " | " + EnemysGameBoard[7, 5] + " | " + EnemysGameBoard[8, 5] + " | " + EnemysGameBoard[9, 5] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 7 | " + YoureGameBoard[0, 6] + " | " + YoureGameBoard[1, 6] + " | " + YoureGameBoard[2, 6] + " | " + YoureGameBoard[3, 6] + " | " + YoureGameBoard[4, 6] + " | " + YoureGameBoard[5, 6] + " | " + YoureGameBoard[6, 6] + " | " + YoureGameBoard[7, 6] + " | " + YoureGameBoard[8, 6] + " | " + YoureGameBoard[9, 6] + " |    |   "; resultat = resultat + " 7 | " + EnemysGameBoard[0, 6] + " | " + EnemysGameBoard[1, 6] + " | " + EnemysGameBoard[2, 6] + " | " + EnemysGameBoard[3, 6] + " | " + EnemysGameBoard[4, 6] + " | " + EnemysGameBoard[5, 6] + " | " + EnemysGameBoard[6, 6] + " | " + EnemysGameBoard[7, 6] + " | " + EnemysGameBoard[8, 6] + " | " + EnemysGameBoard[9, 6] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 8 | " + YoureGameBoard[0, 7] + " | " + YoureGameBoard[1, 7] + " | " + YoureGameBoard[2, 7] + " | " + YoureGameBoard[3, 7] + " | " + YoureGameBoard[4, 7] + " | " + YoureGameBoard[5, 7] + " | " + YoureGameBoard[6, 7] + " | " + YoureGameBoard[7, 7] + " | " + YoureGameBoard[8, 7] + " | " + YoureGameBoard[9, 7] + " |    |   "; resultat = resultat + " 8 | " + EnemysGameBoard[0, 7] + " | " + EnemysGameBoard[1, 7] + " | " + EnemysGameBoard[2, 7] + " | " + EnemysGameBoard[3, 7] + " | " + EnemysGameBoard[4, 7] + " | " + EnemysGameBoard[5, 7] + " | " + EnemysGameBoard[6, 7] + " | " + EnemysGameBoard[7, 7] + " | " + EnemysGameBoard[8, 7] + " | " + EnemysGameBoard[9, 7] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + " 9 | " + YoureGameBoard[0, 8] + " | " + YoureGameBoard[1, 8] + " | " + YoureGameBoard[2, 8] + " | " + YoureGameBoard[3, 8] + " | " + YoureGameBoard[4, 8] + " | " + YoureGameBoard[5, 8] + " | " + YoureGameBoard[6, 8] + " | " + YoureGameBoard[7, 8] + " | " + YoureGameBoard[8, 8] + " | " + YoureGameBoard[9, 8] + " |    |   "; resultat = resultat + " 9 | " + EnemysGameBoard[0, 8] + " | " + EnemysGameBoard[1, 8] + " | " + EnemysGameBoard[2, 8] + " | " + EnemysGameBoard[3, 8] + " | " + EnemysGameBoard[4, 8] + " | " + EnemysGameBoard[5, 8] + " | " + EnemysGameBoard[6, 8] + " | " + EnemysGameBoard[7, 8] + " | " + EnemysGameBoard[8, 8] + " | " + EnemysGameBoard[9, 8] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";
            resultat = resultat + "10 | " + YoureGameBoard[0, 9] + " | " + YoureGameBoard[1, 9] + " | " + YoureGameBoard[2, 9] + " | " + YoureGameBoard[3, 9] + " | " + YoureGameBoard[4, 9] + " | " + YoureGameBoard[5, 9] + " | " + YoureGameBoard[6, 9] + " | " + YoureGameBoard[7, 9] + " | " + YoureGameBoard[8, 9] + " | " + YoureGameBoard[9, 9] + " |    |   "; resultat = resultat + "10 | " + EnemysGameBoard[0, 9] + " | " + EnemysGameBoard[1, 9] + " | " + EnemysGameBoard[2, 9] + " | " + EnemysGameBoard[3, 9] + " | " + EnemysGameBoard[4, 9] + " | " + EnemysGameBoard[5, 9] + " | " + EnemysGameBoard[6, 9] + " | " + EnemysGameBoard[7, 9] + " | " + EnemysGameBoard[8, 9] + " | " + EnemysGameBoard[9, 9] + " |\n";
            resultat = resultat + "   -----------------------------------------           -----------------------------------------\n";

            return resultat;
        }
        //Jo der
    }
}
