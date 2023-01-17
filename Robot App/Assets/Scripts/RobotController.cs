using System;

public static class RobotController
{
    public static void StartMoving(MoveDir direction)
    {
        onStartMoving?.Invoke(direction);
    }

    public static void StopMoving()
    {
        onStopMoving?.Invoke();
    }

    public static event Action<MoveDir> onStartMoving;
    public static event Action onStopMoving;
}
