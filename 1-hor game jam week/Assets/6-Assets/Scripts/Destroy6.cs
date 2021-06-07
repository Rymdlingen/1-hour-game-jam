using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy6 : MonoBehaviour
{
    public GameObject cubePrefab;
    bool newEgg;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -170)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(cubePrefab, new Vector3(Mathf.Ceil(transform.position.x - 10), transform.position.y, transform.position.z), transform.rotation);

        Destroy(gameObject);
    }
}
