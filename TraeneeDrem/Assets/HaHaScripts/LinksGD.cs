using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LinksGD : MonoBehaviour
{
    [SerializeField] private Button _buttonBird;
    [SerializeField] private Button _buttonGramma;
    private void Awake()
    {
        _buttonBird.onClick.AddListener(StartFlappyBird);
        _buttonGramma.onClick.AddListener(StartGrammaTests);
    }
    private void StartFlappyBird()
    {
        SceneManager.LoadScene("FlappyBird");
    }
    private void StartGrammaTests()
    {
        SceneManager.LoadScene("StartExamRef");
    }
}
