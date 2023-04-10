using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movemario : MonoBehaviour
{
    [SerializeField] private Sprite ded;
    [SerializeField] private GameObject vnutri;
    [SerializeField] private EdgeCollider2D vneshkol;
    public float speed;
    public float jump;
    float moveVelocity;
    bool grounded = true;
    private void Start()
    {
        speed = 5f;
        jump = 5f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }
        moveVelocity = 0;
        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
        if(collision.gameObject.tag == "Kill")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = ded;
            vnutri.SetActive(false);
            collision.gameObject.GetComponent<EdgeCollider2D>().enabled = false;   
        }
        if(collision.gameObject.name == "FLAG")
        {
            Debug.Log("end");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
}
