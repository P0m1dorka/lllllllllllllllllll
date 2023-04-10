using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadTambler : MonoBehaviour
{
    [SerializeField] private Button _button;
    private void Update()
    {
        if(PlayerPrefs.GetInt("MailLoad") ==1)
        {
            _button.onClick.AddListener(LoadTamblerScene);
        }
        else
        {
            _button.onClick.AddListener(LoadMainGD);
        }
    }
    private void LoadMainGD()
    {
        SceneManager.LoadScene("MainTamblerGD");
    }
    private void LoadTamblerScene()
    {
        SceneManager.LoadScene("MainTamblerCleaner");
    }
}
