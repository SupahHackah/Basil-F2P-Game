using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour
{
    public void ButtonPressed()
    {
        //Actual Game
        SceneManager.LoadScene(1);

        //Character Select Test
        //SceneManager.LoadScene(3);
        
    }
}
