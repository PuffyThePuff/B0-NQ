using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformCounterBehavior : MonoBehaviour
{
    [SerializeField] private PlatformHandling listHolder;
    private Text platformText;

    // Start is called before the first frame update
    void Start()
    {
        platformText = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    public void UpdatePlatformCount()
    {
        platformText.text = (LevelAttributeHandling.Instance.platformCount - listHolder.GetUsedCount()).ToString();
    }
}