using Csharp_MatrixProject;
using System.ComponentModel;

startUp();



//Agrega los personajes al array
static void startUp()
{
    Character c = new Character();
    Neo n = new Neo();
    Smith sm = new Smith();
    Matrix m = new Matrix();
    bool endGame = false;
    int countBoard = 0;
    int seconds = 0;
    CharacterFactory cf = new CharacterFactory();
    NeoFactory nf = new NeoFactory();
    SmithFactory smf = new SmithFactory();
    MatrixFactory mf = new MatrixFactory();

    Character[,] board;
    Character[,] charAlive = new Character[m.Raws, m.Cols];
    List<Character> charactersArray;

    //Metemos los personajes en un Array
    charactersArray = cf.charInArray(nf, smf);

    //Los repartimos por el tablero
    board = mf.matrixCreation(charactersArray);
    mf.boardPrint(board);
    Console.WriteLine("");
    Thread.Sleep(2000);





    while (seconds < 20 || !endGame)
    {
        seconds++;
        countBoard = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] != null)
                {
                    countBoard++;
                }
            }
        }


        if (seconds % 1 == 0)
        {
            Console.WriteLine("TURNO PERSONAJE");
            m.charactTurn(charactersArray, board);
            mf.boardPrint(board);
            Console.WriteLine("");

        }
        if (seconds % 2 == 0)
        {
            Console.WriteLine("TURNO SMITH");
            m.smithTurn(board);
            mf.boardPrint(board);
            Console.WriteLine("");
        }
        if (seconds % 5 == 0)
        {
            Console.WriteLine("TURNO NEO");
            m.neoTurn(charactersArray, board);
            mf.boardPrint(board);
            Console.WriteLine("");
        }
        if (countBoard == 2)
        {
            endGame = true;
        }

        Thread.Sleep(1000);
    }

}


















