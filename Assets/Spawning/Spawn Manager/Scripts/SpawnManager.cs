using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ImageTarget;

    [SerializeField]
    private GameObject UpperBound;

    [SerializeField]
    private GameObject LowerBound;

    [SerializeField]
    private GameObject LeftBound;

    [SerializeField]
    private GameObject RightBound;

    [SerializeField]
    private int ObstacleCounter;

    [SerializeField]
    private List<GameObject> Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        float RandomZ, RandomX;
        int randomObstacleIDX;

        for(int i = 0; i < ObstacleCounter; i++)
        {
            RandomZ = Random.Range(LeftBound.transform.position.z, RightBound.transform.position.z);
            RandomX = Random.Range(LowerBound.transform.position.x, UpperBound.transform.position.x);
            GameObject obstacle = Instantiate(this.Obstacle[0].gameObject, new Vector3(RandomX, 0.0f, RandomZ), Quaternion.Euler(0.0f, 0.0f, 0.0f));
            obstacle.transform.parent = ImageTarget.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
