using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer playerSprite;
    Rigidbody rigidbody;
    bool isJumping = false;

    public float jumpForce;
    float realSpriteX;
    float realSpriteY;

    Vector3 basePosition;

    // Start is called before the first frame update
    void Start()
    {
        playerSprite = transform.GetChild(0).GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        realSpriteX = transform.position.x;
        realSpriteY = transform.position.y;

        basePosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                playerSprite.flipX = true;
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                playerSprite.flipX = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        if (isJumping)
        {
            realSpriteX = transform.position.x;
            realSpriteY = transform.position.y;

            float newSpriteX = Mathf.Ceil(realSpriteX);
            float newSpriteY = Mathf.Ceil(realSpriteY);

            playerSprite.transform.position = new Vector3(newSpriteX, newSpriteY, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isJumping = false;
            transform.position = basePosition;
            playerSprite.transform.localPosition = Vector3.zero;
        }
    }
}
