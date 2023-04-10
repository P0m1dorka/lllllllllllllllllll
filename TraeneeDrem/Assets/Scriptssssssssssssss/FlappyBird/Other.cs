using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Other : Scene
{
    [SerializeField] private GameObject _death;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _pause;


   
    
    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathZone")
        {
            Time.timeScale = 0;
            _pause.SetActive(false);
            _death.SetActive(true);
        }
    }
   
    
}
