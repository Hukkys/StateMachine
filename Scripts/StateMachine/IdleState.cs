using UnityEngine;

public class IdleState : ControllerState
{
    
    public IdleState(StateMachine state) : base(state) { }


    public override void Enter()
    {


        stateMachine.dependencyOptions.animator.CrossFade("Idle", 0.01f);

    }

    public override void Update()
    {
        if (stateMachine.dependencyOptions.inputControl.AxisHorizontalMove != 0)
        {
            stateMachine.ChangeState(stateMachine.walkState);
            
        }
        Debug.Log(stateMachine.dependencyOptions.inputControl.AxisHorizontalMove);
    }

    public override void FixedUpdate()
    {



    }

    public override void Exit()
    {




    }


}
