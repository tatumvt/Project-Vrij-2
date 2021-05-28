using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OVRInput;

public class GameManager : MonoBehaviour
{
    public GameObject scent;
    public Button endTurnBTN;
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            scent.SetActive(true);
            StartCoroutine(TimeoutEndTurnButton());
        }
        else
        {
            scent.SetActive(false);
        }
    }
    public IEnumerator TimeoutEndTurnButton()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            yield return new WaitForSeconds(5f);
            scent.SetActive(false);
            yield return new WaitForSeconds(1f);
            scent.SetActive(true);
        }
      }

    }

