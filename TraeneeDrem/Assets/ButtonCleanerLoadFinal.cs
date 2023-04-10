using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCleanerLoadFinal : MonoBehaviour
{
    [SerializeField] private Button _button;
    private void Update()
    {
        _button.onClick.AddListener(LoadFinalScene);
    }
    private void LoadFinalScene()
    {
        SceneManager.LoadScene("FinalCLeaner");
    }
}
