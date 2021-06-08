using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeloenWiggle2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateZ(gameObject, 8, 1f).setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
