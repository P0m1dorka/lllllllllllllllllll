using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private int score;
    [SerializeField] private TMP_Text scoretext;
    [SerializeField] private TMP_Text deathtext;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("ScoreBird",score);
        scoretext.text = $"Score: {score.ToString()}";
        deathtext.text = $"{score.ToString()}";
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "ScoreZone")
        {
            score++;
        }
    }
}
