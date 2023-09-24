using Csharp_MatrixProject;

Character[] charactersArray = new Character[10];
Character c;
CharacterFactory cF = new CharacterFactory();
Matrix m = new Matrix();
MatrixFactory mF = new MatrixFactory();
Character[,] board = new Character[m.Raws, m.Cols];
int charactersInMatrix = 4;

//Agrega los personajes al array
cF.namesInArrays(charactersArray);

cF.imprimirCharacters(charactersArray);

c.charDeaths(charactersArray); 


//Distribuir los personajes por el tablero
mF.matrixCreation(charactersArray, board);

mF.boardPrint(board);








