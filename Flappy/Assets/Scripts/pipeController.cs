using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    private GameObject pipe;
    private Rigidbody2D pipePhysics;
    private BoxCollider2D pipeCollider;
    public float pipeSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {

        pipe = this.gameObject;
        pipePhysics = pipe.GetComponent<Rigidbody2D>();
        pipeCollider = pipe.GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        pipePhysics.velocity = new Vector2(-pipeSpeed, 0);
        if (pipe.transform.position.x < -12)
        {
            Destroy(pipe);
        }
    }
}
