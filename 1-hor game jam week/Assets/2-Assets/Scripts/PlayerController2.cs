using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody rb;
    private float oneRotation = 45f;
    private float rotationTimer = .3f;
    private float rotationCountdown;
    private bool isRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rotationCountdown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRotating)
        {
            // left
            if (Input.GetAxis("Horizontal") < 0)
            {
                transform.Rotate(rb.rotation.x, -oneRotation, rb.rotation.z);
                rotationCountdown = rotationTimer;
                isRotating = true;
            }
            // right
            else if (Input.GetAxis("Horizontal") > 0)
            {
                transform.Rotate(rb.rotation.x, oneRotation, rb.rotation.z);
                rotationCountdown = rotationTimer;
                isRotating = true;
            }
            // up
            else if (Input.GetAxis("Vertical") > 0)
            {
                transform.Rotate(rb.rotation.x, -oneRotation, rb.rotation.z);
                rotationCountdown = rotationTimer;
                isRotating = true;
            }
            // down
            else if (Input.GetAxis("Vertical") > 0)
            {
                transform.Rotate(rb.rotation.x, oneRotation, rb.rotation.z);
                rotationCountdown = rotationTimer;
                isRotating = true;
            }
        }

        if (isRotating && rotationCountdown > 0)
        {
            rotationCountdown -= Time.deltaTime;
        }
        else if (isRotating)
        {
            rotationCountdown = 0;
            isRotating = false;
        }
    }
}
