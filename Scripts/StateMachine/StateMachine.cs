using UnityEngine;

public class StateMachine
{
    ControllerState currentState;

    public DependencyOptions dependencyOptions;
    public IdleState idleState { get; private set; }
    public WalkState walkState { get; private set; }
    public RunState runState { get; private set; }
    public FallingState fallingState { get; private set; }
    public Copy copy { get; private set; }

    public StateMachine(PlayerController controller, DependencyOptions dependency)
    {
        dependencyOptions = dependency;

        idleState = new IdleState(this);
        walkState = new WalkState(this);
        runState = new RunState(this);
        fallingState = new FallingState(this);
        copy = new Copy(this);

        ChangeState(idleState);
    }

    public virtual void Enter() { }

    public virtual void Update() { }

    public virtual void FixedUpdate() { }

    public virtual void Exit() { }

    public virtual void OnCollisionEnter(Collision collision) { }

    public virtual void OnTriggerEnter(Collider other) { }

    public void ChangeState(ControllerState newState)
    {

        if (currentState != null) 
        {
            currentState.Exit();
        }
        currentState = newState;
        currentState.Enter();
    }
}

