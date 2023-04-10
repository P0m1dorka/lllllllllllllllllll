using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoScript : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _image;
    [SerializeField] private GameObject _imageReady;

    private void Start()
    {
        _image.SetActive(true);
        _imageReady.SetActive(false);
    }
    private void Awake()
    {
        _button.onClick.AddListener(GoScene);
    }
    private void GoScene()
    {
        _image.SetActive(false);
        _imageReady.SetActive(true);
        SceneManager.LoadScene("TestCleanerScene");
    }
}
