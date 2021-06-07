using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeurSpoorStarter : MonoBehaviour
{
    public int index;
    public GameManager gm;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.ActivateScent(index);
            Destroy(this);
        }
    }
}
