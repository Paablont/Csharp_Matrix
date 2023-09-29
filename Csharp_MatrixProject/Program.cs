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

   
    
    while (seconds <= 20)
    {
        seconds++;

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
        Thread.Sleep(1000);
    }
    

}


















