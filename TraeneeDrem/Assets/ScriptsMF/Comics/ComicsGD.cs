using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComicsGD : MonoBehaviour
{
    [SerializeField] private GameObject[] _images;
    private int _index = 0;
    private void Start()
    {
        for (int i = 0; i < _images.Length; i++)
        {
            _images[i].SetActive(false);
        }
        _images[0].SetActive(true);
    }
    private void Update()
    {
        if (_index == _images.Length - 1)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("Main");
            }
        }

        if (_index == _images.Length - 1)
        {

        }
        else
        {
            if (Input.anyKeyDown)
            {
                MoveComics();
            }
        }
    }
    public void MoveComics()
    {
        _index += 1;
        _images[_index].SetActive(true);
        Debug.Log(_index);
        Debug.Log("78");
    }
}
