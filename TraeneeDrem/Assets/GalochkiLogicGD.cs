using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GalochkiLogicGD : MonoBehaviour
{
    [SerializeField] private GameObject _imageGalochka;
    [SerializeField] private GameObject _imageGalochka2;
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _imageButton;
    [SerializeField] private GameObject _imageButtonReady;
    [SerializeField] private PlayerPrefsSaving _answersExam;
    [SerializeField] private TestResultCleaner _answersCleaner;
    private string _AndreysPrefGalochka;
    private void Start()
    {
        _button.interactable = false;
        _imageGalochka.SetActive(false);
        _imageGalochka2.SetActive(false);
        _imageButtonReady.SetActive(false);
        _imageButton.SetActive(true);
        if (PlayerPrefs.GetInt("ScoreBird") >= 10)
        {
            _imageGalochka.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Galochka1") >=7)
        {
            _imageGalochka2.SetActive(true);
        }
    }
    private void Update()
    {
        if (_imageGalochka.activeInHierarchy == true && _imageGalochka2.activeInHierarchy == true)
        {
            _button.interactable = true;
            PlayerPrefs.SetInt("MailLoad", 2);
        }
        else
        {
            _button.interactable = false;
        }
        if (_button.interactable == false)
        {
            _imageButtonReady.SetActive(false);
            _imageButton.SetActive(true);
        }
        else
        {
            _imageButtonReady.SetActive(true);
            _imageButton.SetActive(false);
        }
    }
}
