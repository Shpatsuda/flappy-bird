using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{
      public int jump = 1;
      private GameObject bird;
      private Rigidbody2D birdPhysics;
      private CircleCollider2D birdCollider;
      public GameObject screenBorders;
      private BoxCollider2D screenCollider;
      public bool dead;
      private float birdZRotation;
      public float minClampRot = -85;
      public float maxClampRot = 20;
      public float birdrotspeed = 1;
      private float rotationAngle;
      private Quaternion birdClampRot;

        // Start is called before the first frame update
    void Start()
    {
        bird = this.gameObject;
        birdPhysics = bird.GetComponent<Rigidbody2D>();
        birdCollider = bird.GetComponent<CircleCollider2D>();
        screenCollider = screenBorders.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (!dead))
        {
            birdPhysics.velocity = Vector2.zero;
            birdPhysics.AddForce(Vector2.up * jump);
        }

        if (dead == true)
        {
            birdPhysics.bodyType = RigidbodyType2D.Static;
        }

        if ((rotationAngle < minClampRot) || (rotationAngle > maxClampRot))
        {

            bird.transform.rotation = Quaternion.Slerp(bird.transform.rotation, birdClampRot, 0.04f);

        }

        birdZRotation = birdPhysics.velocity.y * birdrotspeed;
        bird.transform.Rotate(new Vector3(0, 0, birdZRotation));
        rotationAngle = bird.transform.rotation.z;
        Mathf.Clamp(rotationAngle, minClampRot, maxClampRot);
        birdClampRot = Quaternion.Euler(0, 0, rotationAngle);


    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider = screenCollider)
        {
            dead = true;
        }
    }
}
