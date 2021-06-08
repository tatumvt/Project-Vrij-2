using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioSource noise;
    public AudioClip[] audioClipArray;

    public AudioSource hungry;
    public AudioClip[] audioClipArray2;
    public bool disableSfx;
    public float delay;

    public AudioSource sniff;
    public AudioClip[] audioClipArray3;

    public AudioSource meow;
    public AudioClip[] audioClipArray4;

    public AudioSource miauw;
    public AudioClip[] audioClipArray5;

    // Update is called once per frame
    public void playEat()
    {
        noise.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        noise.PlayOneShot(noise.clip);
    }

    public void playMeow()
    {
        meow.clip = audioClipArray4[Random.Range(0, audioClipArray4.Length)];
        meow.PlayOneShot(meow.clip);
    }

    private void Awake()
    {
        StartCoroutine(playAudio());
    }

    public void playRumble()
    {
        if (disableSfx != true)
        {
            hungry.clip = audioClipArray2[Random.Range(0, audioClipArray2.Length)];
            hungry.PlayOneShot(hungry.clip);
        }
    }
    IEnumerator playAudio()
    {
        yield return new WaitForSeconds(delay);
        playRumble();
        StartCoroutine(playAudio());
    }

    public void playMiauw()
    {
        if (disableSfx != true)
        {
            miauw.clip = audioClipArray5[Random.Range(0, audioClipArray5.Length)];
            miauw.PlayOneShot(miauw.clip);
        }
    }

    public void playSniff()
    {
        sniff.clip = audioClipArray3[Random.Range(0, audioClipArray3.Length)];
        sniff.PlayOneShot(sniff.clip);
    }
}
