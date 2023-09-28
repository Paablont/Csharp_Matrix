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
    
    CharacterFactory cf = new CharacterFactory();
    NeoFactory nf = new NeoFactory();
    SmithFactory smf = new SmithFactory();
    MatrixFactory mf = new MatrixFactory();
    
    Character[,] board;
    Character[,] charAlive = new Character[m.Raws, m.Cols];
    Character[] charactersArray;

    //Metemos los personajes en un Array
    charactersArray = cf.charInArray(nf, smf);

    //Los repartimos por el tablero
    board = mf.matrixCreation(charactersArray);
    mf.boardPrint(board);
    Console.WriteLine("");
    Thread.Sleep(2000);

    //Turno personaje
    c.charDeath(charactersArray, board);
    //m.charactTurn(board);
    mf.boardPrint(board);
    Console.WriteLine("");
    Thread.Sleep(2000);

    //Turno smith
    //sm.smithMove(board);
    //sm.killCharacter(board);
    //mf.boardPrint(board);
    m.smithTurn(board);
    mf.boardPrint(board);
    Console.WriteLine("");
    Thread.Sleep(2000);

    m.neoTurn(charactersArray, board);
    mf.boardPrint(board);
    Console.WriteLine("");
    Thread.Sleep(2000);







}


















