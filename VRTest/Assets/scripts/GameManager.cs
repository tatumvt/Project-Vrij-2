using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject scent;
    public GameObject[] paths;
    public int currentPath;
    public Animation[] pathAnim;
    public Animator test;
    public bool started, overTime;

    void Update()
    {
        if (!Input.GetKey(KeyCode.R))
        {
            test.speed = 0;
            started = false;
            StopCoroutine(TimeoutEndTurnButton());
        }

        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKey(KeyCode.R))
        {

            //scent.SetActive(true);

            //if (!paths[currentPath].GetComponent<ParticleSystem>().isPlaying)
            //{
            //    paths[currentPath].GetComponent<ParticleSystem>().Play();

            //}
            //if (!pathAnim[currentPath].GetComponent<Animation>().isPlaying)
            //{
            //    pathAnim[currentPath].GetComponent<Animation>().enabled = true;
            //    pathAnim[currentPath].GetComponent<Animation>().Play();
            //}
            //else
            //{
            //    pathAnim[currentPath].GetComponent<Animation>().enabled = true;
            //}

            if (!started && overTime == false)
            {
                StartCoroutine(TimeoutEndTurnButton());
                started = true;
            }

        }
        else
        {
            paths[currentPath].GetComponent<ParticleSystem>().Stop();
            //pathAnim[currentPath].GetComponent<Animation>().Stop();
            // scent.SetActive(false);
        }
    }
    public IEnumerator TimeoutEndTurnButton()
    {

        test.speed = 1;
        //pathAnim[currentPath].GetComponent<Animation>().enabled = true;
        paths[currentPath].GetComponent<ParticleSystem>().Play();
        
        yield return new WaitForSeconds(5f);
        paths[currentPath].GetComponent<ParticleSystem>().Pause();
        test.speed = 0;
        //pathAnim[currentPath].GetComponent<Animation>().enabled = false;
        overTime = true;
        yield return new WaitForSeconds(1f);
        overTime = false;
        started = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            paths[currentPath].GetComponent<ParticleSystem>().Stop();
            pathAnim[currentPath].GetComponent<Animation>().Stop();
            paths[currentPath + 1].GetComponent<ParticleSystem>().Play();
            pathAnim[currentPath + 1].GetComponent<Animation>().Play();

            currentPath = currentPath + 1;
        }
    }

}

