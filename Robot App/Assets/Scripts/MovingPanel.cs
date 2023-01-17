using UnityEngine;

public class MovingPanel : MonoBehaviour
{
    public void StartMoveForward()
    {
        RobotController.StartMoving(MoveDir.Forward);
    }

    public void StartMoveBackward()
    {
        RobotController.StartMoving(MoveDir.Backward);
    }

    public void StartMoveLeft()
    {
        RobotController.StartMoving(MoveDir.Left);
    }

    public void StartMoveRight()
    {
        RobotController.StartMoving(MoveDir.Right);
    }

    public void StopMove()
    {
        RobotController.StopMoving();
    }
}
