using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelContent
{
    [SerializeField]
    private float timeLimit; 

    [SerializeField]
    private float timeRemaining;

    [SerializeField]
    private int obstacleCount;

    [SerializeField]
    private int platformCount;

    public LevelContent()
    {
        
    }

    public float TimeLimit
    {
        get
        {
            return timeLimit;
        }
        set
        {
            timeLimit = value;
        }
    }

    public float TimeRemaining
    {
        get
        {
            return timeRemaining;
        }

        set
        {
            timeRemaining = value;
        }
    }

    public int ObstacleCount
    {
        get { 
            return obstacleCount; 
        }
        set
        {
            obstacleCount = value;
        }
    }

    public int PlatformCount
    {
        get { 
            return platformCount; 
        }
        set
        {
            platformCount = value;
        }
    }
}
