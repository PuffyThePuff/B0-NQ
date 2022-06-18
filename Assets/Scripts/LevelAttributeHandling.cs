using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelAttributeHandling : MonoBehaviour
{
    private static LevelAttributeHandling instance;

    public static LevelAttributeHandling Instance
    {
        get
        {
            if (instance == null) instance = FindObjectOfType<LevelAttributeHandling>();
            return instance;
        }
    }

    public bool activeLevel = false;

    public float timeLimit;
    public float timeRemaining;
    public float timeToBeat = 0.0f;

    public int obstacleCount;
    public int platformCount;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (activeLevel)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0) activeLevel = false;
        }
    }

    public void SetLevelAttributes(int levelType)
    {
        switch (levelType)
        {
            case 1:
                timeLimit = 60.0f;
                timeRemaining = 60.0f;
                obstacleCount = 2;
                platformCount = 2;
                break;
            case 2:
                timeLimit = 80.0f;
                timeRemaining = 80.0f;
                obstacleCount = 3;
                platformCount = 2;
                break;
            case 3:
                timeLimit = 80.0f;
                timeRemaining = 80.0f;
                obstacleCount = 5;
                platformCount = 2;
                break;
        }
    }

    public void UpdateBestTime()
    {
        if (timeRemaining > timeToBeat) timeRemaining = timeToBeat;
    }

    public void setActiveLevel(bool activeLevel)
    {
        this.activeLevel = activeLevel;
    }
}