using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonAgain : MonoBehaviour
{
    [SerializeField] private Button _button;
    private void Awake()
    {
        _button.onClick.AddListener(ChangeSceneAgain);
    }
    private void ChangeSceneAgain()
    {
        _button.image.color = new Color(0,0,0);
        SceneManager.LoadScene("BrowderXyandeks");
    }
}
