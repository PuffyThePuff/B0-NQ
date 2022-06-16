using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimerBehavior : MonoBehaviour
{
    private Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        timerText.text = Math.Floor(LevelAttributeHandling.Instance.timeRemaining).ToString();
    }
}