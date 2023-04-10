using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeComeBack : MonoBehaviour
{
    [SerializeField] private Button _home;
    private void Awake()
    {
        _home.onClick.AddListener(HomeBack);
    }
    private void HomeBack()
    {
        SceneManager.LoadScene("Hyandex");
    }
}
