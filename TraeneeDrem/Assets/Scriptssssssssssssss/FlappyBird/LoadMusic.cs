using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMusic : MonoBehaviour
{
    [SerializeField] private Button _home;
    [SerializeField] private Button _music;
    [SerializeField] private GameObject _musiccanvas;
    bool open;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
        _home.onClick.AddListener(GoHome);
        _music.onClick.AddListener(Canava);
    }
    private void GoHome()
    {
        SceneManager.LoadScene("Hyandex");
    }
    private void Canava()
    {
        if(open=false) 
        {
            _musiccanvas.SetActive(true);
            open = true;
        }
        else
        {
            _musiccanvas.SetActive(false);
            open = false;
        }
        
    }
    
}
