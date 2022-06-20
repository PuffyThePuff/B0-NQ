using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseWorld : MonoBehaviour
{

    [SerializeField]
    private GameObject PausePanel;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void worldPause(int timeValue)
    {
        if(timeValue == 0)
        {
            Time.timeScale = 0;
            PausePanel.SetActive(true);
        }
        else if(timeValue == 1)
        {
            Time.timeScale = 1;
            PausePanel.SetActive(false);
        }
    }
}
