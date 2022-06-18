using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTimeCounter : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Text BestTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateBestScore()
    {
        BestTime.text = LevelAttributeHandling.Instance.timeToBeat.ToString();
    }
}
