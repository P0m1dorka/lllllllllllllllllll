using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _bird;
    [SerializeField] private float _jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        _jumpforce = 3.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) 
        { 
            Jump();          
        }
    }
    void Jump()
    {
        _bird.velocity = Vector2.up * _jumpforce;
    }
}
