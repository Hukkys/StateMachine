using UnityEngine;


[System.Serializable]
public class DependencyOptions
{
    [field: SerializeField] public Animator animator { get; private set; }
    [field: SerializeField] public InputControl inputControl { get; private set; }
    [field: SerializeField] public Rigidbody RB { get; private set; }
    [field: SerializeField] public bool Run { get; private set; }
    [field: SerializeField] public bool Jump { get; private set; }
    [field: SerializeField] public IsGrounded isGround { get; private set; }

}