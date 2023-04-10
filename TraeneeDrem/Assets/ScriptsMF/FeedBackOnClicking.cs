using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedBackOnClicking : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _WatchMail;
    [SerializeField] private GameObject _buttonImg;
    [SerializeField] private GameObject _buttonImgReady;
    private void Start()
    {
        _WatchMail.SetActive(false);
    }
    private void Update()
    {
        _button.onClick.AddListener(WatchUrMail);
    }

    private void WatchUrMail()
    {
        Debug.Log("YES");
        _button.interactable = false;
        _WatchMail.SetActive(true);
        _buttonImg.SetActive(false);
        _buttonImgReady.SetActive(false);
    }
}
