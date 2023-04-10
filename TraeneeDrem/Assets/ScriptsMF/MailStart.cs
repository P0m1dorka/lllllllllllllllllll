using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MailStart : MonoBehaviour
{
    [SerializeField] private Button _mailButton;
    [SerializeField] private GameObject _imageMail;
    [SerializeField] private GameObject _imageMailReady;
    private void Start()
    {
        if (PlayerPrefs.GetInt("MailLoad")==1)
        {
            _imageMail.SetActive(false);
            _imageMailReady.SetActive(true);
            _mailButton.interactable = true;
        }
        else
        {
            _imageMail.SetActive(true);
            _imageMailReady.SetActive(false);
            _mailButton.interactable = false;
        }
    }
    void Update()
    {
        _mailButton.onClick.AddListener(LoadMailScene);
    }
    private void LoadMailScene()
    {
        SceneManager.LoadScene("");
    }
}
