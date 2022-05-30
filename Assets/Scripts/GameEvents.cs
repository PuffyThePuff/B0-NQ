using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    //to subscribe use Gamevents.current.onAntReachGoal += <function here>;
    //to invoke use Gamevents.current.AntReachGoal();

    private void Awake()
    {
        current = this;
    }

    //sample basic event
    public event Action onAntReachGoal;
    public void AntReachGoal()
    {
        onAntReachGoal?.Invoke();
    }

    //event that passes an int
    public event Action<int> onPuzzleMatch;
    public void PuzzleMatch(int dmg)
    {
        onPuzzleMatch?.Invoke(dmg);
    }

    public event Action onResetGame;
    public void ResetGame()
    {
        onResetGame?.Invoke();
    }

    public event Action onScore;
    public void Score()
    {
        onScore?.Invoke();
    }

    public event Action onGameOver;
    public void GameOver()
    {
        onGameOver?.Invoke();
    }
}
