// See https://aka.ms/new-console-template for more information
using Csharp_MatrixProject;

Console.WriteLine("Hello, World!");
CharacterFactory c = new CharacterFactory() ;
Character charact = c.charCreation();

Console.WriteLine(charact.ToString());