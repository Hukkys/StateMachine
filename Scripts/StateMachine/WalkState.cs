
using UnityEngine;

public class WalkState : ControllerState
{
    public WalkState(StateMachine stateMachine) : base(stateMachine) { }
    ControllerState controllerState;


    private bool _isGrounded;
    private Rigidbody _rb;
    private InputControl _inputControl;
    private Animator _animator;
    private bool _direction;

    public float moveHorizontal;
    public float Speed = 10;



    public override void Enter()
    {
        _rb = stateMachine.dependencyOptions.RB;
        _animator = stateMachine.dependencyOptions.animator;
        _inputControl = stateMachine.dependencyOptions.inputControl;
        moveHorizontal = stateMachine.dependencyOptions.inputControl.AxisHorizontalMove;
        _isGrounded = stateMachine.dependencyOptions.isGround.isGrounded;
        _animator = stateMachine.dependencyOptions.animator;
        _direction = stateMachine.dependencyOptions.direction.directionForward;

    }

    public override void Update()
    {
        Exit();

        if (_direction)
        {
            _animator.CrossFade("Walk", 0.01f);
        }
        else _animator.CrossFade("WalkBack", 0.01f);
    }

    public override void FixedUpdate()
    {
        Move();
    }

    public override void Exit()
    {

    }
    
    private void Move()
    {
        if (_isGrounded)
        {

            if (moveHorizontal != 0)
            {
                _rb.velocity = new(moveHorizontal * Speed, _rb.velocity.y, 0);

            }
        }
        else stateMachine.ChangeState(stateMachine.fallingState);
    }
   

}
