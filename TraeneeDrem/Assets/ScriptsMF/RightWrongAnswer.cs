using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightWrongAnswer : MonoBehaviour
{
    [SerializeField] private Button _rightButtons;
    [SerializeField] private Button _wrongButtons;

    [SerializeField] private Button _buttonBack;
    [SerializeField] private Button _buttonAnswer;

    [SerializeField] private GameObject _imageBack;
    [SerializeField] private GameObject _imageAnswer;
    [SerializeField] private GameObject _imageAnswerReady;

    [SerializeField] private GameObject[] _questions;

    [SerializeField] private GameObject[] _imagesOfTasks;
    [SerializeField] private GameObject[] _imagesOfTasksReady;
    [SerializeField] private Button[] _buttonsTasks;

    private int _schet;
    private void Start()
    {
        for(int i = 0; i < _questions.Length; i++)
        {
            _questions[i].SetActive(false);
        }
        _questions[6].SetActive(true);
    }
    private void Update()
    {
           
    }

    private void RightAnswer()
    {
        ++_schet;
    }
}
