using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

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
        timerText.text = Math.Round(LevelAttributeHandling.Instance.timeRemaining, 2).ToString();
    }
}