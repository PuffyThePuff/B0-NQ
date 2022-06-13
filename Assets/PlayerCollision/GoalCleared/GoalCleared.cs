using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCleared : MonoBehaviour
{
    [SerializeField]
    private GameObject GoalClearedPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Debug.Log("Game Over");
            GoalClearedPanel.SetActive(true);
        }
    }
}
