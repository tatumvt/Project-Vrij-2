using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSCene : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "button")
        {
            Application.Quit();
        }


    }
}
