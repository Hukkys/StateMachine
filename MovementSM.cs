using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    [SerializeField] PlayerController playerController;

    public DependencyOptions dependencyOptions;
    public IdleState idleState { get; private set; }
    public WalkState walkState { get; private set; }

    public MovementSM(ControllerState context, DependencyOptions dependency)
    {
        dependencyOptions = dependency;

        idleState = new IdleState(this);
        walkState = new WalkState(this);
    }


    private void Awake()
    {
        idleState = new IdleState(this);
        walkState = new WalkState(this);
    }
    protected override ControllerState GetInitialState()
    {
        return idleState;
    }

}
