using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    int randomObject;

    float timer;
    float timerIntervall;

    int cubes;

    // Start is called before the first frame update
    void Start()
    {
        timerIntervall = Random.Range(2, 6);
        cubes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timerIntervall)
        {
            Instantiate(objectPrefabs[randomObject], transform.position, transform.rotation);

            timerIntervall = Random.Range(2, 5);
            timer = 0;
        }

        if (GameObject.FindGameObjectsWithTag("cube").Length > cubes)
        {
            print(cubes);
            cubes = GameObject.FindGameObjectsWithTag("cube").Length;
            print(cubes);
        }

        if (cubes <= 4)
        {
            randomObject = 0;
        }
        else if (cubes >= 5 && cubes <= 9)
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
        else if (cubes >= 10 && cubes <= 12)
        {
            if (Random.Range(0, 2) == 0)
            {
                if (Random.Range(0, 2) == 0)
                {
                    randomObject = 1;
                }
                else
                {
                    randomObject = 2;
                }
            }
            else
            {
                randomObject = 0;
            }
        }
        else
        {
            randomObject = 2;
        }
    }
}
