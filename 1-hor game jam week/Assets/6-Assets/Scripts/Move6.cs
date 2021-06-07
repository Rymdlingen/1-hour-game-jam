using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move6 : MonoBehaviour
{
    float realX;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        realX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                realX += Time.deltaTime * speed;
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                realX -= Time.deltaTime * speed;
            }

            int newX = Mathf.CeilToInt(realX);

            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }
}
