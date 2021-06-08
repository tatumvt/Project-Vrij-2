using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawn : MonoBehaviour
{
    public GameObject cat;
    public GameObject muisjes;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cat.SetActive(true);
            muisjes.SetActive(true);
        }
    }
}
