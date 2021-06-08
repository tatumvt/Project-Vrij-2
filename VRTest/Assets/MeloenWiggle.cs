using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeloenWiggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalY(gameObject, -77,1f).setEaseInOutBack().setLoopPingPong();
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
