using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reload : MonoBehaviour
{
    [SerializeField] private Button _button;
    void Start()
    {
        _button.onClick.AddListener(Load);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Load()
    {
        SceneManager.LoadScene("FlappyBird");
    }
}
