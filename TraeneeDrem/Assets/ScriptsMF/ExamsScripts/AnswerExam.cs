using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerExam : MonoBehaviour
{
    [SerializeField] private Button _answerButton;
    [SerializeField] private Toggle[] _toggles;
    private void Awake()
    {
    }
    public void AddPrefs(string sceneName)
    {
        for(int i = 0; i< _toggles.Length; i++)
        {
            if(_toggles[i].isOn && _toggles[i].transform.tag == "Right")
            {
                Debug.Log("NUDA");
                PlayerPrefs.SetInt("Answers", PlayerPrefs.GetInt("Answers") + 1);
                SceneManager.LoadScene(sceneName);
            }
        }
        for (int i = 0; i < _toggles.Length; i++)
        {
            if (_toggles[i].isOn && _toggles[i].transform.tag == "Right")
            {
                Debug.Log("NUNET");
                Debug.Log(PlayerPrefs.GetInt("Answers") + "answers");
                SceneManager.LoadScene(sceneName);
            }
        }
        SceneManager.LoadScene(sceneName);
    }
}
