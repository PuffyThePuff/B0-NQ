using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ImageTarget;

    [SerializeField]
    private List<GameObject> positions;

    [SerializeField]
    private int ObstacleCounter;

    [SerializeField]
    private List<GameObject> Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        List<int> values = Enumerable.Range(0, positions.Count).ToList();
        int randomObstacleIDX;

        for (int i = 0; i < ObstacleCounter; i++)
        {
            randomObstacleIDX = values[Random.Range(0, values.Count)];
            GameObject obstacle = Instantiate(this.Obstacle[0].gameObject, positions[randomObstacleIDX].gameObject.transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
            obstacle.transform.parent = ImageTarget.transform;
            values.Remove(randomObstacleIDX);
        }

        Debug.Log(values.Count());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
