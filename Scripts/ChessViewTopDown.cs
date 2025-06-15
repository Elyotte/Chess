using Godot;
using System;

public partial class ChessViewTopDown : Node2D
{
    const int CELLSIZE = 64;
    Texture2D cellTextures = ResourceLoader.Load<Texture2D>("res://Textures/CellTexture64.png");
    int[,] gridColor;

    public override void _Ready()
    {
        // Setup board position and cells
        Position = GetViewportRect().Size * .5f + new Vector2(-CELLSIZE * 4f, -CELLSIZE * 3.5f);
        gridColor = ChessModel.GetInstance().gridColor;
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
                lSprite.Position = new Vector2(CELLSIZE * x, CELLSIZE * y);
                int color = gridColor[x, y];
                lSprite.Modulate = GlobalMethods.ReturnColor(color);
            }
        }
    }
}
