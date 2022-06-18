using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformCounter : MonoBehaviour
{
    // Start is called before the first frame update
    private Text PlatformText;

    void Start()
    {
        UpdateCounter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCounter()
    {
        PlatformText = this.gameObject.GetComponent<Text>();
        PlatformText.text = LevelAttributeHandling.Instance.platformCount.ToString();
    }
}
