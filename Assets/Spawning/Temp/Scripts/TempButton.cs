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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Panel.SetActive(false);



        LevelAttributeHandling.Instance.timeRemaining = LevelAttributeHandling.Instance.timeLimit;
        Time.timeScale = 1.0f;

        
        
    }

    
}
