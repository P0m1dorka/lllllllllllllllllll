using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlScripts : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("LvlExam",0);
        PlayerPrefs.SetInt("Answers", 0);
        SceneManager.LoadScene("StartExamRef");
    }
}
