using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEndScreen5 : MonoBehaviour
{
    ChangeSprite5 tank;
    SpriteRenderer spriteRenderer;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
        tank = GameObject.Find("tank1").GetComponent<ChangeSprite5>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tank.isFullyUpdated)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0 && spriteRenderer.enabled == false)
        {
            spriteRenderer.enabled = true;
        }
    }
}
