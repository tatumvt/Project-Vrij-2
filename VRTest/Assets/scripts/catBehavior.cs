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
    public bool disableSfx;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        animator = GetComponent<Animator>(); 
    }
    private void FixedUpdate()
    {
        moveCat(movement);
    }

    void moveCat(Vector3 direction)
    {
        am.StartCoroutine(playCatNoise());
        float step = 3f * moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(this.transform.position, player.position, step) ;
        transform.LookAt(player);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            animator.SetInteger("catNearby", 1);
            if (disableSfx != true)
            {
                am.playMeow();
            }
            moveSpeed = moveSpeed - 2f;
            animator.SetInteger("catNearby", 0);


        }
    }
    IEnumerator playCatNoise()
    {
        yield return new WaitForSeconds(10f);
        am.playMiauw();
        StartCoroutine(playCatNoise());
    }
}
