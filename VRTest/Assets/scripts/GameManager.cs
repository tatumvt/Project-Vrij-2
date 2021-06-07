using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ParticleSystem ps;
    public Animator animator;
    public GameObject cat;

    public GameObject[] geursporen;

    public int currentScent;

    public audioManager am;
    public AudioSource geurspoorAudioSource;

    private void Start()
    {
        ActivateScent(0);
    }
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKey(KeyCode.R))
        {
            if(geurspoorAudioSource != null)
            {
                geurspoorAudioSource.volume = Mathf.Lerp(geurspoorAudioSource.volume, 1, Time.deltaTime);
            }
            if (!ps.isPlaying)
            {
                am.playSniff();
                ps.Play();
            }
            animator.SetFloat("SpeedModifier", 1f);
        }
        if (OVRInput.GetUp(OVRInput.Button.One) || Input.GetKeyUp(KeyCode.R))
        {
            if (geurspoorAudioSource != null)
            {
                geurspoorAudioSource.volume = Mathf.Lerp(geurspoorAudioSource.volume, 0, Time.deltaTime);
            }
            if (ps.isPlaying)
            {
                ps.Stop();
            }
            animator.SetFloat("SpeedModifier", 0f);
        }
    }
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Fish")
        {
            //stop current animation
            cat.SetActive(true);
        }
    }
    public void ActivateScent(int index)
    {
        Debug.Log("activate scent" + index);
        if(geurspoorAudioSource != null)
        {
            geurspoorAudioSource.Stop();
        }
        if(ps != null)
        {
            ps.Stop();
        }
        if (animator != null)
        {
            animator.SetFloat("SpeedModifier", 0f);
        }

        currentScent = index;
        ps = geursporen[currentScent].GetComponent<ParticleSystem>();
        animator = geursporen[currentScent].GetComponent<Animator>();
        geurspoorAudioSource = geursporen[currentScent].GetComponent<AudioSource>();
    }
}

