using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answering : MonoBehaviour
{
    [SerializeField] private Toggle[] _toggles;
    [SerializeField] private GameObject _image;
    [SerializeField] private GameObject _imageReady;
    [SerializeField] private Button _button;
    private void Update()
    {
        for(int i = 0; i<_toggles.Length; i++)
        {
            if(_toggles[i].isOn)
            {
                _button.interactable = true;
                _image.SetActive(false);
                _imageReady.SetActive(true);
            }
            else
            {
                _button.interactable = true;
                _image.SetActive(false);
                _imageReady.SetActive(true);
            }
        }
    }
}
