using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBehaviour : MonoBehaviour
{
    [SerializeField] private Transform destination;
    private BoxCollider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = this.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = destination.position;
            Debug.Log("portal");
        }
    }
}
