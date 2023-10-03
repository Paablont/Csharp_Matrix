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
    int neoRange;

    int seconds = 0;
    CharacterFactory cf = new CharacterFactory();
    NeoFactory nf = new NeoFactory();
    SmithFactory smf = new SmithFactory();
    MatrixFactory mf = new MatrixFactory();
    Character[,] board;
    Character[,] charAlive = new Character[m.Raws, m.Cols];
    List<Character> charactersList;

    //Metemos los personajes en un Array
    charactersList = cf.charInList(nf, smf);

    //Los repartimos por el tablero
    board = mf.matrixCreation(charactersList);
    mf.boardPrint(board);
    Console.WriteLine("");
    Thread.Sleep(2000);

    while (seconds <= 20 && !endGame)
    {
        seconds++;
        

        if (seconds % 1 == 0)
        {
            Console.WriteLine("TURNO PERSONAJE");
            m.charactTurn(charactersList, board);
            mf.boardPrint(board);
            Console.WriteLine("");
        }

        if (seconds % 2 == 0)
        {
            //He intentado mover a Smith en su turno tantas casillas como deberia pero no lo consigo. Dejo comentado mi intento
            //neoRange = sm.neoRange(board);

            //for (int i = 0; i < neoRange; i++)
            //{
            Console.WriteLine("TURNO SMITH");
            m.smithTurn(board);
            mf.boardPrint(board);

            //}

            Console.WriteLine("");
        }

        if (seconds % 5 == 0)
        {
            Console.WriteLine("TURNO NEO");
            m.neoTurn(charactersList, board);
            mf.boardPrint(board);
            Console.WriteLine("");
        }

        foreach (Character p in board)
        {
            if (p != null)
            {
                countBoard++;
            }
        }

        if (countBoard == 2)
        {
            endGame = true;
            seconds = 20;
            Console.WriteLine("SMITH HA MATADO A TODOS LOS CIUDADANOS: GANADOR SMITH");
        }
        


        Thread.Sleep(1000);
    }


}


















