using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject randomEnemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        randomEnemy = enemyPrefabs[Random.Range(0, 3)];

        if (Random.Range(0, 200) == 0)
        {
            Instantiate(randomEnemy, transform.position, transform.localRotation);
        }
    }
}
