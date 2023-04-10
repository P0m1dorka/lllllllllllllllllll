using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsOnOf : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _image;
    [SerializeField] private GameObject _imageReady;
    private void Start()
    {
        _image.SetActive(true);
        _imageReady.SetActive(false);
    }
    private void Update()
    {
        if(_button.interactable)
        {
            _image.SetActive(false);
            _imageReady.SetActive(true);
        }
        else
        {
            _image.SetActive(true);
            _imageReady.SetActive(false);
        }
    }
}
