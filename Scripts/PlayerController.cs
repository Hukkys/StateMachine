using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] DependencyOptions dependency;
    StateMachine stMachine;

    private void Awake()
    {
        stMachine = new StateMachine(this, dependency);
    }

    void Update()
    {
        stMachine.Update();
    }

    void FixedUpdate()
    {
        stMachine.FixedUpdate();

    }

    private void OnCollisionEnter(Collision collision)
    {
        stMachine.OnCollisionEnter(collision);
    }
    private void OnTriggerEnter(Collider other)
    {
        stMachine.OnTriggerEnter(other);
    }










}

