using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    

    void Start(){
        // private CylinderCollider ground

    }
    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("ground"))
        {
            Debug.Log("collision with ground");

        }
    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }
}