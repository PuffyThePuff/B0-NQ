using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GoalCleared : MonoBehaviour
{
    [SerializeField]
    private GameObject GoalClearedPanel;

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

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {

            LevelAttributeHandling.Instance.UpdateBestTime();

            Time.timeScale = 0;
            
            ScoreText.text = "Time Left: " + Math.Round(LevelAttributeHandling.Instance.timeRemaining, 2);
            GoalClearedPanel.SetActive(true);
        }
    }
}
