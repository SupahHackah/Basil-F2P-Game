using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCharacter : MonoBehaviour
{
    public GameObject[] Characters;

    private void start()
    {
        for( int i = 0; i < Characters.Length; i++)
        {
            Characters[(i)].SetActive(false);
        }

        Characters[0].SetActive(true);
    }
}
