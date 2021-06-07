using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite5 : MonoBehaviour
{
    int flowers = 0;
    public int newFlowersNeeded = 1;
    int nextUpdate;

    public Sprite[] sprites;
    int currentSprite = 0;
    public bool isFullyUpdated;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        nextUpdate = newFlowersNeeded;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("flower").Length > flowers)
        {
            flowers = GameObject.FindGameObjectsWithTag("flower").Length;
        }

        if (flowers >= nextUpdate && !isFullyUpdated)
        {
            nextUpdate += newFlowersNeeded;
            currentSprite++;
            spriteRenderer.sprite = sprites[currentSprite];

            if (currentSprite == sprites.Length - 1)
            {
                isFullyUpdated = true;
            }
        }
    }
}
