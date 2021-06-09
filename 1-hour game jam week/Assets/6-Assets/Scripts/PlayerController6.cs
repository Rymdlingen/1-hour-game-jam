using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController6 : MonoBehaviour
{
    SpriteRenderer robotSprite;
    Rigidbody rigidbody;

    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        robotSprite = transform.GetChild(0).GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                robotSprite.flipX = true;
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                robotSprite.flipX = false;
            }
        }
    }
}
