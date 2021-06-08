using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDown : MonoBehaviour
{
    public int Loopcount;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalY(gameObject, -169, 2f).setEaseOutBack().setLoopCount(Loopcount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
