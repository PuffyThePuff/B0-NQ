using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        LevelAttributeHandling[] components = GameObject.FindObjectsOfType<LevelAttributeHandling>();
        foreach (LevelAttributeHandling comp in components)
            Destroy(comp.gameObject);



        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        //LevelAttributeHandling.Instance.setActiveLevel(false);

        
    }
}
