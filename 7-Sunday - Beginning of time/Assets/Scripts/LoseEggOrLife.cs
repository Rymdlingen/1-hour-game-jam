using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseEggOrLife : MonoBehaviour
{

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
        Destroy(gameObject.GetComponent<SphereCollider>());

        if (GameObject.FindGameObjectsWithTag("collectedEgg").Length > 0)
        {
            Destroy(GameObject.FindGameObjectsWithTag("collectedEgg")[GameObject.FindGameObjectsWithTag("collectedEgg").Length - 1].gameObject);
        }
        else
        {

        }
    }
}