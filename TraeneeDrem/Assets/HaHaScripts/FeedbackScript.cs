using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FeedbackScript : MonoBehaviour
{
    [SerializeField] private Button _buttonGD;
    [SerializeField] private Button _buttonCleaner;
    private void Update()
    {
        
    }
    public void LoadHaHaTask(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
