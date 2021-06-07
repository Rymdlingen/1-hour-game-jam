using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestBefore3 : MonoBehaviour
{
    public float goodWithinThisTime = 2f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = goodWithinThisTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
