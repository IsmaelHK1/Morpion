namespace Morpion.Models;

public class BoardModel
{
    /* 
        *** reference :
        ** 0 = null
        ** 1 = X
        ** 2 = O
    */
    public int[,] start { get; set; } = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
    public int[,] current { get; set; } = new int[3, 3];
}

public class Localization
{
    public int PosX { get; set; }
    public int PosY { get; set; }

}