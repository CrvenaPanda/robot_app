using System.Collections.Generic;

public static class Utils
{
    public static string DirectionToString(MoveDir direction)
    {
        return _directionToString[direction];
    }

    private static Dictionary<MoveDir, string> _directionToString = new Dictionary<MoveDir, string>
    {
        { MoveDir.None, "None"},
        { MoveDir.Forward, "Forward"},
        { MoveDir.Backward, "Backward"},
        { MoveDir.Left, "Left"},
        { MoveDir.Right, "Right"}
    };
}
