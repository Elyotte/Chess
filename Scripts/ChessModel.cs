using Godot;
using System;

public partial class ChessModel
{
    private static ChessModel _Instance;

    // Singleton instance
    public static ChessModel GetInstance()
    {
        if (_Instance != null) return _Instance;
        else return new ChessModel();
    }

    private ChessModel()
    {
        _Instance = this;
    }
   
    ChessPiece[,] chessPiecesPositions = new ChessPiece[8, 8];
    public int[,] gridColor = new int[8, 8]
    {
        {1,0,1,0,1,0,1,0},
        {0,1,0,1,0,1,0,1},
        {1,0,1,0,1,0,1,0},
        {0,1,0,1,0,1,0,1},
        {1,0,1,0,1,0,1,0},
        {0,1,0,1,0,1,0,1},
        {1,0,1,0,1,0,1,0},
        {0,1,0,1,0,1,0,1}
    };
    

    

    
}