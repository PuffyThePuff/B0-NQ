using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class TempButton : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject Panel;

    [SerializeField]
    private GameObject PausePanel;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene("TempLevel1");
        Panel.SetActive(false);



        LevelAttributeHandling.Instance.timeRemaining = LevelAttributeHandling.Instance.timeLimit;
        Time.timeScale = 1.0f;

    }

    private void Awake()
    {
        DontDestroyOnLoad(Panel);
        DontDestroyOnLoad(PausePanel);
    }
}
