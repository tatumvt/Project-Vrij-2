using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Idle : MonoBehaviour
{
    public GameObject Handen, Handen2;
    public Color TriggerColor;
    private GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
        
        LeanTween.moveLocalY(gameObject, -50, 1).setEaseInOutSine().setLoopPingPong();

    }

    //private void ontriggerstay(collider other)
    //{
    //    if (other.gameobject == handen || other.gameobject == handen2)
    //    {
    //        button sbutton = startbutton.getcomponent<button>();
    //        colorblock triggercolor = sbutton.colors;
    //        triggercolor.highlightedcolor = new color(45, 80, 100);
    //    }
    //}
}
