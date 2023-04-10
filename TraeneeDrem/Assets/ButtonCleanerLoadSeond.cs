using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCleanerLoadSeond : MonoBehaviour
{
    [SerializeField] private Button _button;
    private void Update()
    {
        _button.onClick.AddListener(LoadSecondScene);
    }
    private void LoadSecondScene()
    {
        SceneManager.LoadScene("SecondTamblerCleaner");
    }
}
