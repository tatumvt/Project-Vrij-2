using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSlide2 : MonoBehaviour
{
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            Debug.Log(waitTime);
            yield return new WaitForSeconds(waitTime);
            Destroy(GameObject.Find("Tutorial2"));
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitAndPrint(30));
    }
}
