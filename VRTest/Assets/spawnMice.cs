using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnMice : MonoBehaviour
{
    public GameObject mice;
    public GameObject cat;
   
    private void OnTriggerEnter(Collider collider)
    {
        if (cat.activeSelf){
            if (collider.gameObject.tag == "Player")
            {
                mice.SetActive(true);
                SceneManager.LoadScene(2);
            }
        }
    }
}
