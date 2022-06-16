using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHandling : MonoBehaviour
{
    [SerializeField]
    private PlatformCounter platformcounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onTargetLost()
    {
        if (LevelAttributeHandling.Instance.platformCount > 0)
        {
            LevelAttributeHandling.Instance.platformCount = LevelAttributeHandling.Instance.platformCount - 1;
            platformcounter.UpdateCounter();
        }
         
    }
    public void onTargetFound()
    {
        LevelAttributeHandling.Instance.platformCount = LevelAttributeHandling.Instance.platformCount + 1;
        platformcounter.UpdateCounter();
    }
}
