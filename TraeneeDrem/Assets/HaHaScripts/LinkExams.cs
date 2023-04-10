using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LinkExams : MonoBehaviour
{
    [SerializeField] private Button _buttonStart; 
    [SerializeField] private Button _buttonCleaner;
    private void Awake()
    {
        _buttonStart.onClick.AddListener(StartExamStarting);
        _buttonCleaner.onClick.AddListener(CleanerExamsStarting);
    }
    private void StartExamStarting()
    {
        SceneManager.LoadScene("StartExamRef");
    }
    private void CleanerExamsStarting()
    {
        SceneManager.LoadScene("MegaTestMenu");
    }
}
