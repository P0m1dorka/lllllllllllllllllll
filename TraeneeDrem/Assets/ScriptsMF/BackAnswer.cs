using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackAnswer : MonoBehaviour
{
    [SerializeField] private Button _buttonBack; 
    [SerializeField] private Button _buttonAnswer;
    [SerializeField] private GameObject _imageBack;
    [SerializeField] private GameObject _imageAnswer;
    [SerializeField] private GameObject _imageAnswerReady;
    private bool _ready;
    private void Start()
    {
        _imageAnswer.SetActive(true);
        _imageAnswerReady.SetActive(false);
        _buttonAnswer.interactable= false;
    }
    private void Awake()
    {
        _buttonAnswer.onClick.AddListener(FKSG);
    }
    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.J))
        {
            _ready = true;
            _buttonAnswer.interactable = true;
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            _ready = false;
            _buttonAnswer.interactable = false;
        }
        if(_ready)
        {
            _imageAnswer.SetActive(false);
            _imageAnswerReady.SetActive(true);
        }
        else
        {
            _imageAnswer.SetActive(true);
            _imageAnswerReady.SetActive(false);
        }
    }
    private void FKSG()
    {
        Debug.Log("78");
    }
}
