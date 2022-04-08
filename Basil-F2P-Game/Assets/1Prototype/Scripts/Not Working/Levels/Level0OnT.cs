using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level0OnT : MonoBehaviour
{
    public bool _level0 = false;

    void OnTriggerEnter(Collider other)
    {
               
         if(other.gameObject.tag == "Player" )
        {
            _level0 = true;
            level0Function();
            print("Player has entered level0");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player" )
        {
            _level0 = false;
            print("Player has exited level0");
        }
    }

    public void level0Function()
    {

    }
}
