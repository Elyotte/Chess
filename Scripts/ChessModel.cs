using Godot;
using System;

public partial class ChessModel : Node2D
{
    private static ChessModel _Instance;

    // Singleton instance
    public static ChessModel instance
    {
        get { if (_Instance != null) return instance;
            else return new ChessModel();
        }
        set { _Instance = value; }
    }

    private ChessModel()
    {
        instance = this;
    }

    ChessPiece[,] chessPiecesPositions = new ChessPiece[8, 8];
    int[,] gridColor = new int[8, 8]
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
    const int CELLSIZE = 64;
    Texture2D cellTextures = ResourceLoader.Load<Texture2D>("res://Textures/CellTexture64.png");

    public override void _Ready()
    {
        Position = GetViewportRect().Size * .5f +  new Vector2(-CELLSIZE * 4f,-CELLSIZE * 3.5f);
        GD.Print("Hello");
        base._Ready();
        InitChessBoard();
    }

    void InitChessBoard()
    {
        Sprite2D lSprite = new Sprite2D();
        for (int x = 0; x < gridColor.GetLength(0); x++)
        {
            for (int y = 0; y < gridColor.GetLength(1); y++)
            {
                lSprite = new Sprite2D();
                AddChild(lSprite);
                lSprite.Texture = cellTextures;
                lSprite.Position = new Vector2(CELLSIZE * x, CELLSIZE * y );
                int color = gridColor[x, y];
                lSprite.Modulate = GlobalMethods.ReturnColor(color);
            }
        }
    }
}