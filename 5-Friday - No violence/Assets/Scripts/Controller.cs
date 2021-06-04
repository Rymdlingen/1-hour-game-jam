using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Camera mainCamera;

    public Sprite[] icon;

    SpriteRenderer iconRenderer;

    // place things

    public GameObject[] flowerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        iconRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).x) - 3, Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).y) - 2, transform.position.z);

        // place things

        if (Input.GetMouseButtonDown(0))
        {
            float mouseX = mainCamera.ScreenToWorldPoint(Input.mousePosition).x;
            float mouseY = mainCamera.ScreenToWorldPoint(Input.mousePosition).y;

            if (mouseY < -30 && mouseX < 45 && mouseX > -55)
            {
                // blue.
                Instantiate(flowerPrefab[1], new Vector3(Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).x) - 3, Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).y) - 2, transform.position.z), flowerPrefab[1].transform.rotation);
            }
            else if (mouseY < -30)
            {
                if (Random.Range(0, 3) == 0)
                {
                    // red.
                    Instantiate(flowerPrefab[0], new Vector3(Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).x) - 3, Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).y) - 2, transform.position.z), flowerPrefab[0].transform.rotation);
                }
                else
                {
                    // blue.
                    Instantiate(flowerPrefab[1], new Vector3(Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).x) - 3, Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).y) - 2, transform.position.z), flowerPrefab[1].transform.rotation);
                }
            }
            else if ((mouseY < -11 && (mouseX < -30 || mouseX > 20)) || (mouseY < -25 && (mouseX < -25 || mouseX > 5)) || mouseY < -30)
            {
                if (Random.Range(0, 5) == 0)
                {
                    // blue.
                    Instantiate(flowerPrefab[1], new Vector3(Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).x) - 3, Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).y) - 2, transform.position.z), flowerPrefab[1].transform.rotation);
                }
                else
                {
                    // red.
                    Instantiate(flowerPrefab[0], new Vector3(Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).x) - 3, Mathf.Ceil(mainCamera.ScreenToWorldPoint(Input.mousePosition).y) - 2, transform.position.z), flowerPrefab[0].transform.rotation);
                }
            }
        }
    }

    public void ChangeIcon(int button)
    {
        iconRenderer.sprite = icon[button];
    }
}