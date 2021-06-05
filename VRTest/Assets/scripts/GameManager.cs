using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ParticleSystem ps;
    public Animator animator;
    public GameObject cat;

    public ParticleSystem[] geursporen;

    public int currentScent;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        ps = GetComponentInChildren<ParticleSystem>();
        currentScent = 0;
    }
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKey(KeyCode.R))
        {
            if (!ps.isPlaying)
            {
                ps.Play();
            }
            animator.SetFloat("SpeedModifier", 1f);
        }
        if (OVRInput.GetUp(OVRInput.Button.One) || Input.GetKeyUp(KeyCode.R))
        {
            if (ps.isPlaying)
            {
                ps.Stop();
            }
            animator.SetFloat("SpeedModifier", 0f);
        }
    }
   

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Fruit")
        {
            //stop current animation
            //start next animation
            currentScent = currentScent + 1;
            animator.Play(geursporen[currentScent].name);
        }

        if (collider.gameObject.tag == "Fish")
        {
            //stop current animation
            cat.SetActive(true);
        }
    }


}

