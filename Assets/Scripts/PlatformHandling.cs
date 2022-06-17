using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHandling : MonoBehaviour
{
    private List<GameObject> usedPlatforms = new List<GameObject>();

    public void OnTargetFound(GameObject platform)
    {
        if (usedPlatforms.Count < LevelAttributeHandling.Instance.platformCount) {
            usedPlatforms.Add(platform);
        }
    }

    public void OnTargetLost(GameObject platform)
    {
        usedPlatforms.Remove(platform);
    }

    public int GetUsedCount()
    {
        return usedPlatforms.Count;
    }
}