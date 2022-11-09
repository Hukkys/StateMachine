using UnityEngine;

public class IdleState : ControllerState
{
    public IdleState(MovementSM movementSM) : base(movementSM)
    {

    }

    public override void Enter()
    {
        base.Enter();

        
    }

    public override void Update()
    {
        base.Update();



        if (c)
        {
            stateMachine.ChangeState(((MovementSM) stateMachine).walkState);
        }
    }

    
}
