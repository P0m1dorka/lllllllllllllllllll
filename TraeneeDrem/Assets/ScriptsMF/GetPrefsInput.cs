using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPrefsInput : MonoBehaviour
{
    private void Update()
    {
        if(Input.anyKeyDown)
        {
            Debug.Log(PlayerPrefs.GetInt("Answers") + "answers");
        }    
    }
}
