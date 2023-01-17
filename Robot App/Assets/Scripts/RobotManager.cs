using UnityEngine;

public class RobotManager : MonoBehaviour
{
    void OnEnable()
    {
        RobotController.onStartMoving += OnStartMoving;
        RobotController.onStopMoving += OnStopMoving;
    }

    void OnDisable()
    {
        RobotController.onStartMoving -= OnStartMoving;
        RobotController.onStopMoving -= OnStopMoving;
    }

    void OnStartMoving(MoveDir direction)
    {
        if (_moveDir == direction)
        {
            return;
        }

        Debug.Log("Moving: " + Utils.DirectionToString(direction));
        _moveDir = direction;
    }

    void OnStopMoving()
    {
        Debug.Log("Stopped moving.");
        _moveDir = MoveDir.None;
    }

    MoveDir _moveDir = MoveDir.None;
}
