using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMice : MonoBehaviour
{
    public GameObject mice;

    private void OnTriggerEnter(Collider collider)
    {
        //find gameobject tag = cat 
        if (collider.gameObject.tag == "Player")
        {
            mice.SetActive(true);
        }
    }
}
