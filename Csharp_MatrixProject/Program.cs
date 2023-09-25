using Csharp_MatrixProject;

CharacterFactory cf = new CharacterFactory();
NeoFactory nf = new NeoFactory();
SmithFactory smf = new SmithFactory();
Character[] charactersArray = new Character[200];
Matrix m = new Matrix();
MatrixFactory mf = new MatrixFactory();
Character[,] board = new Character[m.Raws,m.Cols];
int charactersInMatrix = 4;

//WOWOWO

//Agrega los personajes al array
cf.charInArray(charactersArray,nf, smf);

//cf.imprimirCharacters(charactersArray);

//Distribuir los personajes por el tablero
mf.matrixCreation(charactersArray, board);

mf.boardPrint(board);








