using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eating : MonoBehaviour
{
    private OVRGrabbable blokje;
    public audioManager am;

    private void Awake()
    {
        blokje = GetComponent<OVRGrabbable>();
    }

   private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MainCamera")
        {
            am.playEat();
            // blokje.GrabEnd(Vector3.zero, Vector3.zero);
            blokje.grabbedBy.ForceRelease(blokje);
            this.gameObject.SetActive(false);
           // Destroy(this.gameObject);
        }
    }
}
