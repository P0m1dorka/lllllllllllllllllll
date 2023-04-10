using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscMoment : MonoBehaviour
{
    [SerializeField] private Button _button;
    private void Start()
    {
        _button.onClick.AddListener(Continue);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            _button.gameObject.SetActive(true);
        }
    }
    private void Continue()
    {
        _button.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
