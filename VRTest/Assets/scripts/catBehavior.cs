using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catBehavior : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;

    private Vector3 movement;
    public float moveSpeed = 4f;

    public audioManager am;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        am.StartCoroutine(playCatNoise());
        animator = GetComponentInChildren<Animator>(); 
    }
    private void Update()
    {
        float step = 3f * moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(this.transform.position, player.position, step);
        transform.LookAt(player);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //animator.SetInteger("catNearby", 1);
            if (!am.meow.isPlaying)
            {
                
                am.playMeow();
            }
            if (moveSpeed >= 2.5f)
            {
                moveSpeed = moveSpeed - 0.5f;
            }
            //animator.SetInteger("catNearby", 0);
            if(moveSpeed < 2)
            {
                moveSpeed = 2;
            }

        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("play");
            //animator.SetInteger("catNearby", 1);
            if (!am.meow.isPlaying)
            {
                
                am.playMeow();
            }
            if (moveSpeed < 2.5f)
            {
                moveSpeed = moveSpeed + 2f;
            }
            //animator.SetInteger("catNearby", 0);
        }
    }
    IEnumerator playCatNoise()
    {
        yield return new WaitForSeconds(10f);
        if (!am.miauw.isPlaying)
        {
            am.playMiauw();
        }
        StartCoroutine(playCatNoise());
    }
}
