using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnMice : MonoBehaviour
{
    public GameObject mice;
    public GameObject cat;
    private void Start()
    {
        cat = GameObject.FindGameObjectWithTag("Cat");
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (cat.activeSelf){
            if (collider.gameObject.tag == "Player")
            {
                SceneManager.LoadScene(2);
                mice.SetActive(true);
            }
        }
    }
}
