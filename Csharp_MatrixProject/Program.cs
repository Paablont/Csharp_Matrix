using Csharp_MatrixProject;
using System.ComponentModel;

CharacterFactory cf = new CharacterFactory();
NeoFactory nf = new NeoFactory();
Neo n = new Neo();
SmithFactory smf = new SmithFactory();
Character[] charactersArray = new Character[200];
Character c = new Character() ;
Matrix m = new Matrix();
MatrixFactory mf = new MatrixFactory();
Character[,] board = new Character[m.Raws,m.Cols];
Character[,] charAlive = new Character[m.Raws,m.Cols];

//Agrega los personajes al array
cf.charInArray(charactersArray,nf, smf);

//cf.imprimirCharacters(charactersArray);

//Distribuir los personajes por el tablero
mf.matrixCreation(charactersArray, board);
mf.boardPrint(board);

Thread.Sleep(2000);
//Pruebas de muerte de personajes
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

c.charDeath(board);
Thread.Sleep(2000);
mf.boardPrint(board);

//Pruebas de movimiento de Neo
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

Thread.Sleep(2000);
n.neoMove(board);
mf.boardPrint(board);

//Pruebas de neo generando character
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

Thread.Sleep(2000);
n.theChosenOne(board);
n.charNeoGenerate(charactersArray, board);
mf.boardPrint(board);









