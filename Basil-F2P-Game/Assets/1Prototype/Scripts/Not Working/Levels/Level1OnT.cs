using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1OnT : MonoBehaviour
{
    public bool _level1 = false;

    public void OnTriggerEnter(Collider other)
    {
               
         if(other.gameObject.tag == "Player" )
        {
            _level1 = true;
            print("Player has entered level1");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player" )
        {
            _level1 = false;
            print("Player has exited level1");
        }
    }
}
