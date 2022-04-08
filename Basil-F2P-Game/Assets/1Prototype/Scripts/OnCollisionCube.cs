using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCube : MonoBehaviour
{
    public float DespawnTime = 1.0f;
    
   private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player" )
        {
            //Debug.Log(other);
            Destroy(gameObject, DespawnTime);
        }
    }
}
