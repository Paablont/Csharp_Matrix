using Csharp_MatrixProject;
using System.ComponentModel;

CharacterFactory cf = new CharacterFactory();
NeoFactory nf = new NeoFactory();
Neo n = new Neo();
Smith sm = new Smith();
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
//Pruebas de turno Personaje
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Pruebas de turno personaje");

m.charactTurn(charactersArray, board);
Thread.Sleep(2000);
mf.boardPrint(board);

////Pruebas de turno neo
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("Pruebas de turno neo");

//m.neoTurn(charactersArray, board);
//mf.boardPrint(board);

////Pruebas de movimiento de Smith
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("Pruebas de turno Smith");


//Thread.Sleep(2000);
//m.smithTurn(charactersArray, board);
//mf.boardPrint(board);










