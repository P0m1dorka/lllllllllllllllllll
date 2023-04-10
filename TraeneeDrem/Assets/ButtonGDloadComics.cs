using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonGDloadComics : MonoBehaviour
{
    [SerializeField] private Button _button;
    private void Update()
    {
        _button.onClick.AddListener(LoadFinalSceneGD);
    }
    private void LoadFinalSceneGD()
    {
        SceneManager.LoadScene("FinalGD");
    }
}
