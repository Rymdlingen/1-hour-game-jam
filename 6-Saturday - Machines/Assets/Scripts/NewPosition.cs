using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPosition : MonoBehaviour
{
    float xLimit = -160 + 1;
    float startPosition = 160;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xLimit)
        {
            transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
        }
    }
}
