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

    private int randomObstacleIDX;
    private List<int> values;

    // Start is called before the first frame update
    void Start()
    {
        values = Enumerable.Range(0, positions.Count).ToList();
        

        for (int i = 0; i < ObstacleCounter; i++)
        {
            randomObstacleIDX = values[Random.Range(0, values.Count)];
            GameObject obstacle = Instantiate(this.Obstacle[Random.Range(0, Obstacle.Count)].gameObject, positions[randomObstacleIDX].gameObject.transform.position, positions[randomObstacleIDX].gameObject.transform.rotation);
            obstacle.transform.parent = ImageTarget.transform;
            values.Remove(randomObstacleIDX);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
