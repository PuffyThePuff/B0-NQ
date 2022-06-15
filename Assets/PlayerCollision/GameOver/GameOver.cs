using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverPanel;

    private GameEvents gameEvents;
    private GameObject gg;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Over()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "obstacle")
        {
            Time.timeScale = 0;
            Debug.Log("Game Over");
            //GameEvents.current.GameOver += <>;
            GameOverPanel.SetActive(true);
            //gg = GameObject.FindGameObjectWithTag("gameover");
            //gg.SetActive(true);
        }
    }
}
