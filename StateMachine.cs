using UnityEngine;

public class StateMachine : MonoBehaviour
{
    ControllerState currentState;
    [SerializeField] PlayerController playerController;

    public void Start()
    {
        currentState = GetInitialState();
        
        if (currentState != null) 
        {
            currentState.Enter();
        }
    }
    public void Update()
    {
        currentState.Update();
    }
    public void FixedUpdate()
    {
        currentState.FixedUpdate();
    }
    public void ChangeState(ControllerState newState)
    {
        currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }
    protected virtual ControllerState GetInitialState()
    {
        return null;
    }
}

