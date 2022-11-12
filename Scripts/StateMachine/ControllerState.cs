using UnityEngine;

public abstract class ControllerState 
{
    protected StateMachine stateMachine;

    public ControllerState(StateMachine state)
    {
        stateMachine = state;
    }

    public virtual void Enter() { }

    public virtual void Exit() { }

    public virtual void Update() { }

    public virtual void FixedUpdate() { }

    public virtual void OnCollisionEnter(Collision collision) { }

    public virtual void OnTriggerEnter(Collider other) { }
}

