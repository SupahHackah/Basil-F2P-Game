using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDeletion : MonoBehaviour
{
    public float timer = 5.0f;
    void Awake()
    {
        {
            Destroy(gameObject, timer);
        }
    }
}
