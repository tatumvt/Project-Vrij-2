using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject scent;

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            scent.SetActive(true);
        }
        else
        {
            scent.SetActive(false);
        }
       /* if (Input.GetButtonDown("Button.Two"))
        {
            scent.SetActive(true);
        }else{
            scent.SetActive(false);
        }*/
    }
}
