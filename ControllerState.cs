using UnityEngine;

public abstract class ControllerState
{
    protected StateMachine stateMachine;
    protected MovementSM movementSM;

    public  ControllerState(MovementSM movement)
    {
        movementSM = movement;
    }

    public virtual void Enter() { }

    public virtual void Update() { }

    public virtual void FixedUpdate() { }

    public virtual void Exit() { }
}

