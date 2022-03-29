using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCube : MonoBehaviour
{
    
   private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player" )
        {
            Debug.Log(other);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter (Collider other) 
    {
        Destroy (gameObject);
    }
}
