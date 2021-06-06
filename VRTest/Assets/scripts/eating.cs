using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eating : MonoBehaviour
{
    public OVRGrabbable blokje;
    public audioManager am;
    public OVRGrabber handOne;
    public OVRGrabber handTwo;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MainCamera")
        {
            am.playEat();

            Destroy(this.gameObject);
            handOne.ForceRelease(blokje);
        }
    }
}
