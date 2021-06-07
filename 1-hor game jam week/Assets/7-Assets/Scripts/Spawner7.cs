using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner7 : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    int randomObject;

    float timer;
    float timerIntervall;

    int collectedEggs;

    public Move7 ground;

    // Start is called before the first frame update
    void Start()
    {
        timerIntervall = Random.Range(2, 6);
        collectedEggs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timerIntervall)
        {
            float difference = transform.position.x - ground.realX;
            Vector3 spawnPosition = transform.position;
            spawnPosition.x = ground.realX + Mathf.Ceil(difference);

            Instantiate(objectPrefabs[randomObject], spawnPosition, transform.rotation);

            timerIntervall = Random.Range(2, 5);
            timer = 0;
        }

        if (GameObject.FindGameObjectsWithTag("collectedEgg").Length > collectedEggs)
        {
            collectedEggs = GameObject.FindGameObjectsWithTag("collectedEgg").Length;
        }

        if (collectedEggs <= 4)
        {
            randomObject = 1;
        }
        else if (collectedEggs >= 5 && collectedEggs <= 9)
        {
            if (Random.Range(0, 2) == 0)
            {
                randomObject = 1;
            }
            else
            {
                randomObject = 0;
            }
        }
        else if (collectedEggs >= 10 && collectedEggs <= 12)
        {
            if (Random.Range(0, 1) == 0)
            {
                randomObject = 0;
            }
            else
            {
                randomObject = 0;
            }
        }
        else
        {
            randomObject = 0;
        }
    }
}
