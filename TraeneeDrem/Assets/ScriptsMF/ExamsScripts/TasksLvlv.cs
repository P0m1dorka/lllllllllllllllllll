using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksLvlv : MonoBehaviour
{
    [SerializeField] private GameObject[] _tasks; 
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("LvlExam"));
        for(int i = 0; i < _tasks.Length; i++)
        {
            _tasks[i].SetActive(false);
        }
        PlayerPrefs.SetInt("LvlExam",(PlayerPrefs.GetInt("LvlExam")+1));
        for(int i = 0; i < PlayerPrefs.GetInt("LvlExam");i++)
        {
            _tasks[i].SetActive(true);
        }
        
    }
}
