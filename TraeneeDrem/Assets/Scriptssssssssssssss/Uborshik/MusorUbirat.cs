using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MusorUbirat : MonoBehaviour
{
    private float a;
    // Start is called before the first frame update
    void Start()
    {
        a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            a -= 0.2f;
            gameObject.GetComponent<Renderer>().material.color = new UnityEngine.Color(1f, 1f, 1f,a);

        }
    }
}
