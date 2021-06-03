using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour

{
    Scene MainScene;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "button")
        {
            SceneManager.LoadScene(1);
        }


    }
}


