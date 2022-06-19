using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverPanel;

    private GameEvents gameEvents;
    private GameObject gg;

    [SerializeField]
    private Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Over()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "obstacle" || collision.gameObject.tag == "Border")
        {
            Time.timeScale = 0;
            ScoreText.text = "Time Left: " + Math.Round(LevelAttributeHandling.Instance.timeRemaining, 2);
            GameOverPanel.SetActive(true);
            //gg = GameObject.FindGameObjectWithTag("gameover");
            //gg.SetActive(true);
        }
    }
}
