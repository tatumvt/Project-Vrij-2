using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSlide : MonoBehaviour
{
   
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            Debug.Log(waitTime);
            yield return new WaitForSeconds(waitTime);
            
            Destroy(GameObject.Find("Tutorial1"));
        }


    }



    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(WaitAndPrint(25));
    }

   
}
