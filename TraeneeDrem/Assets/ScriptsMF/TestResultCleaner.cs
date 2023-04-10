using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResultCleaner : MonoBehaviour
{
    private bool _daNet = false;
    public bool DaNet
    {
        get => _daNet;
    }
    private void Start()
    {
        PlayerPrefs.SetInt("Galochka2",5);
        _daNet = true;
    }
}
