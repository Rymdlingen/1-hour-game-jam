using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float speed;
    float realX;
    public int limit;

    // Start is called before the first frame update
    void Start()
    {
        realX = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        realX += Time.deltaTime * speed;
        transform.position = new Vector3(Mathf.Ceil(realX), transform.position.y, transform.position.z);

        if (transform.position.x > limit)
        {
            transform.position = new Vector3(-limit, transform.position.y, transform.position.z);
            realX = -limit;
        }
    }
}
