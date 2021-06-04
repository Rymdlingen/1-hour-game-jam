using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public int speed = 1;
    private float move;
    float newX;
    float newZ;

    float startX;
    float startZ;

    public bool shouldMove = true;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            move = speed * Time.deltaTime;

            newX = Mathf.MoveTowards(transform.position.x, 0, move);
            newZ = Mathf.MoveTowards(transform.position.z, 0, move);

            transform.position = new Vector3(newX, transform.position.y, newZ);

            if (transform.position.x == 0 && transform.position.z == 0)
            {
                Destroy(gameObject);
            }
        }
        else if (!shouldMove)
        {
            move = speed * Time.deltaTime;

            newX = Mathf.MoveTowards(transform.position.x, startX, move);
            newZ = Mathf.MoveTowards(transform.position.z, startZ, move);

            transform.position = new Vector3(newX, transform.position.y, newZ);

            if (transform.position.x == startX && transform.position.z == startZ)
            {
                Destroy(gameObject);
            }
        }
    }
}
