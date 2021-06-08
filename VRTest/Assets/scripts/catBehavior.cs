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


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
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
            am.playMeow();
            moveSpeed = moveSpeed - 2f;

        }
    }
    IEnumerator playCatNoise()
    {
        yield return new WaitForSeconds(10f);
        am.playMiauw();
        StartCoroutine(playCatNoise());
    }
}
