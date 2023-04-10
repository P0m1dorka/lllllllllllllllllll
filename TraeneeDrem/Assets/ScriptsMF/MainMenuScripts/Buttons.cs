using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Button _buttonPlay; 
    [SerializeField] private Button _buttonAutors;
    [SerializeField] private GameObject _imagePlay1;
    [SerializeField] private GameObject _imagePlay2;
    [SerializeField] private GameObject _imageAuthors1;
    [SerializeField] private GameObject _imageAuthors2;
    private void Start()
    {
        _imagePlay1.SetActive(true);
        _imagePlay2.SetActive(false);
        _imageAuthors1.SetActive(true);
        _imageAuthors2.SetActive(false);
    }
    private void Update()
    {
        _buttonAutors.onClick.AddListener(ChangeAuthors);
        _buttonPlay.onClick.AddListener(ChangePlay);
    }
    private void ChangeAuthors()
    {
        _imageAuthors1.SetActive(false);
        _imageAuthors2.SetActive(true);
    }
    private void ChangePlay()
    {
        _imagePlay1.SetActive(false);
        _imagePlay2.SetActive(true);
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
