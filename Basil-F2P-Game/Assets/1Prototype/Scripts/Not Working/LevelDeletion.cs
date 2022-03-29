using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDeletion : MonoBehaviour
{
    private Transform player;

    public float Position;
    public float safeZone = 100;
    public float timer = 5;

    void start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Destroy(gameObject, timer);
        
    }
    void update()
    {
        Position = transform.position.y;
        if(player.position.y - safeZone > Position)
        {
            DestroyLevel(); 
        }
    }

    private void DestroyLevel()
    {
        Destroy(gameObject);
    }
}
