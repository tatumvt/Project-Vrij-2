using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerButton : MonoBehaviour
{
    public Color UIColor;
    public GameObject StartButton;
    // Start is called before the first frame update
    public void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.tag == "button")
        {
            StartButton.GetComponent<Image>().color = UIColor;
        }
    }

    // Update is called once per frame
    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "button")
        {
            StartButton.GetComponent<Image>().color = Color.white;
        }
    }
}
