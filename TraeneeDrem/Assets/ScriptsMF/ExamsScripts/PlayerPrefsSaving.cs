using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrefsSaving : MonoBehaviour
{
    [SerializeField] private GameObject _canvas1;
    [SerializeField] private GameObject _canvas2;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TMP_Text _text2;
    private int _playerPrefsSaved;
    public int PlayerPrefsSaved
    {
        get => _playerPrefsSaved;
    }
    private void Start()
    {
        _canvas1.SetActive(false);
        _canvas2.SetActive(false);
        _playerPrefsSaved = PlayerPrefs.GetInt("Answers");
        PlayerPrefs.SetInt("Galochka1",PlayerPrefs.GetInt("Answers"));
        Debug.Log(_playerPrefsSaved + "answers");
        PlayerPrefs.SetInt("Answers",0);
        Debug.Log(_playerPrefsSaved + "answers");
        if (_playerPrefsSaved>=7)
        {
            _canvas1.SetActive(true);
            _canvas2.SetActive(false);
        }
        else
        {
            _canvas1.SetActive(false);
            _canvas2.SetActive(true);
        }
        _text.text = "Правильных ответов " + _playerPrefsSaved + " из 10.";
        _text2.text = "Правильных ответов " + _playerPrefsSaved + " из 10.";        
    }
}
