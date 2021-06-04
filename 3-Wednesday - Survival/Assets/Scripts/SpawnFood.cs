using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    Ray myRay;      // initializing the ray
    RaycastHit hit; // initializing the raycasthi

    public GameObject[] foodPrefab;
    GameObject randomFood;

    float timer = 1f;
    float timerStartTime = .5f;

    void Update()
    {
        myRay = Camera.main.ScreenPointToRay(Input.mousePosition); // telling my ray variable that the ray will go from the center of

        if (timer < 0)
        {
            if (Physics.Raycast(myRay, out hit))
            { // here I ask : if myRay hits something, store all the info you can find in the raycasthit varible.


                if (Input.GetMouseButton(0))
                {
                    int foodType = Random.Range(0, foodPrefab.Length);
                    randomFood = foodPrefab[foodType];
                    Instantiate(randomFood, new Vector3(hit.point.x, randomFood.transform.position.y, hit.point.z), randomFood.transform.rotation);
                    timer = timerStartTime;
                }
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
