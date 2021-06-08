using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Title_Idle : MonoBehaviour

{
    public Color UIColor;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().color = UIColor;
        LeanTween.rotateZ(gameObject, 10, 5).setEaseInElastic().setLoopPingPong();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
