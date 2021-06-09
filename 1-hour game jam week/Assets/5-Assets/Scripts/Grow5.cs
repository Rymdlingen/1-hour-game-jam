using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow5 : MonoBehaviour
{
    public Sprite[] flowerSprites;

    [SerializeField]
    private float growIntervall;
    public float growth = 0;

    public int currentSprite = 0;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Random.Range(0, 2) == 0)
        {
            spriteRenderer.flipX = true;
            transform.position = new Vector3(transform.position.x + 6, transform.position.y, transform.position.z);
        }

        if (gameObject.CompareTag("red"))
        {
            spriteRenderer.sortingOrder = Mathf.CeilToInt(100 - transform.position.y) - 5;
        }
        else
        {
            spriteRenderer.sortingOrder = Mathf.CeilToInt(100 - transform.position.y);
        }
        growIntervall = Random.Range(15, 30);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSprite < flowerSprites.Length + 1)
        {
            growth += Time.deltaTime;
        }
        else if (growth != 0)
        {
            growth = 0;
        }

        if (growth > growIntervall)
        {
            if (currentSprite == flowerSprites.Length)
            {
                gameObject.tag = "flower";
                currentSprite++;
                return;
            }

            spriteRenderer.sprite = flowerSprites[currentSprite];
            currentSprite++;
            growth = 0;

            if (currentSprite == flowerSprites.Length)
            {
                growIntervall = Random.Range(25, 35);
            }
            else
            {
                growIntervall = Random.Range(50, 70);
            }
        }
    }
}
