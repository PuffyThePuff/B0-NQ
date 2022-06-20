using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoader : MonoBehaviour
{
    private float ticks = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ticks = ticks + Time.deltaTime;
        if(ticks > 1.0f)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    
}
