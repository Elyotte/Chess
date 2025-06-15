using System;
using Godot;

public static class GlobalMethods
{
    static public Color ReturnColor(int pCode)
    {
        switch (pCode)
        {
            case 0:
                return GlobalSettings.whiteColor;
            case 1:
                return GlobalSettings.blackColor;
            default:
                return new Color();
        }
    }
}
