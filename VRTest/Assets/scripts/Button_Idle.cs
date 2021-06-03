using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Idle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalY(gameObject, -50, 1).setEaseInOutSine().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
