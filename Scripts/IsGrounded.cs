using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public bool isGrounded;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit(Collider collider)
    
    {
        if (collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }


}
