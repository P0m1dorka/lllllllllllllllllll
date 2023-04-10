using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TogglesScript : MonoBehaviour
{
    [SerializeField] private Toggle[] _toggles;
    [SerializeField] private Button _buttonNext;
    private int _index;
    public Toggle[] Toggles
    {
        get => _toggles;
    }
    private void Start()
    {
        for(int i = 0; i< _toggles.Length; i++)
        {
            _toggles[i].isOn = false;
            _buttonNext.interactable = false;
        }
    }
    private void Update()
    {
        for (int i = 0; i < _toggles.Length; i++)
        {           
            if(_toggles[i].isOn)
            {
                _index = i;
                _buttonNext.interactable = true;
            }
           //else
           //{
           //    _buttonNext.interactable = false;
           //}
        }
        for(int i = 0; i < _toggles.Length; i++)
        {
            if(i!=_index)
            {
                _toggles[i].isOn = false;
            }
        }
    }
    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
