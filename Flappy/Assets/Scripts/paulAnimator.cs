using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paulAnimator : MonoBehaviour
{
    private GameObject paul;
    private GameObject bird;
    private birdController birdCtrl;
    private SpriteRenderer paulRenderer;
    private float textureOffset;
    public float scrollSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        paul = this.gameObject;
        bird = GameObject.Find("bird");
        birdCtrl = bird.GetComponent<birdController>();
        paulRenderer = paul.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (birdCtrl.dead == false)
        {

            textureOffset = Time.time * scrollSpeed;
            paulRenderer.material.SetTextureOffset("_MainTex", new Vector2(textureOffset, 0));

        }

    }
}
