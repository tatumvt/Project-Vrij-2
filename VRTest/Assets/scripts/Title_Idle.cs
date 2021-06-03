using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Idle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateZ(gameObject, 10, 5).setEaseInElastic().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
