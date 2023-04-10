using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void HomeScene()
    {
        SceneManager.LoadScene(0);
    } 
    public void FlappyBirdScene()
    {

        SceneManager.LoadScene(1);
    }
    
}
