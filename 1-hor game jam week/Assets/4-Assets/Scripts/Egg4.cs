using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg4 : MonoBehaviour
{
    bool warm;
    bool cold;

    bool gettingWarm;
    bool gettingCold;

    float coldCounter;
    float warmCounter;

    float warmIntervalls = 5;

    public Sprite[] eggs;
    private SpriteRenderer eggSprite;

    public SpriteRenderer playerSprite;
    public Sprite[] player;

    public SpriteRenderer lightSprite;

    int currentEgg = 0;

    // Start is called before the first frame update
    void Start()
    {
        eggSprite = GetComponent<SpriteRenderer>();
        eggSprite.sprite = eggs[currentEgg];

        warm = false;
        cold = true;

        gettingWarm = false;
        gettingCold = true;

        warmCounter = 0;
        coldCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (gettingWarm)
        {
            coldCounter = 0;
            warmCounter += Time.deltaTime;
        }
        else if (gettingCold)
        {
            warmCounter = 0;
            coldCounter += Time.deltaTime;
        }

        if (warmCounter > warmIntervalls && currentEgg < eggs.Length - 1)
        {
            currentEgg++;
            eggSprite.sprite = eggs[currentEgg];
            warmCounter = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gettingWarm = true;
        gettingCold = false;
        playerSprite.sprite = player[1];
        lightSprite.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        gettingWarm = false;
        gettingCold = true;
        playerSprite.sprite = player[0];
        lightSprite.gameObject.SetActive(false);
    }
}
