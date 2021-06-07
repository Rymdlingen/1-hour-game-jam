using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEgg : MonoBehaviour
{
    public GameObject collectedEggPrefab;
    int eggIntervall = 5;
    int eggOffset = 9;

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
        if (gameObject.CompareTag("egg"))
        {
            if (GameObject.FindGameObjectsWithTag("collectedEgg").Length > 0)
            {
                eggOffset += eggIntervall * GameObject.FindGameObjectsWithTag("collectedEgg").Length;
            }

            // move egg to behind player
            var egg = Instantiate(collectedEggPrefab, GameObject.Find("dinosaur").transform, false);

            Vector3 eggPosition = egg.transform.localPosition;

            eggPosition.x = -eggOffset;

            egg.transform.localPosition = eggPosition;

            Destroy(gameObject);
        }
    }
}