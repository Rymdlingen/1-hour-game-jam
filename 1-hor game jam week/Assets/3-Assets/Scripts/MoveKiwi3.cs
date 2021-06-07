using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKiwi3 : MonoBehaviour
{
    private Camera mainCamera;
    private Rigidbody rb;

    private Vector3 currentGoal;
    private bool needNewGoal;

    public float maxX;
    public float minX;
    public float maxZ;
    public float minZ;

    public float speed = 5;

    public GameObject kiwiPrefab;

    float eatTimer;
    float eatIntervall = 8f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        needNewGoal = true;
        rb = GetComponent<Rigidbody>();
        eatTimer = eatIntervall;
    }

    // Update is called once per frame
    void Update()
    {
        if (!needNewGoal)
        {
            // Move towards goal
            transform.LookAt(currentGoal, Vector3.up);
            float newX = Mathf.MoveTowards(transform.position.x, currentGoal.x, Time.deltaTime * speed);
            float newZ = Mathf.MoveTowards(transform.position.z, currentGoal.z, Time.deltaTime * speed);

            transform.position = new Vector3(newX, transform.position.y, newZ);

            // Check if new goal is needed
            if (transform.position.x == currentGoal.x && transform.position.z == currentGoal.z)
            {
                needNewGoal = true;
            }
        }
        else
        {
            // Get new goal
            currentGoal = new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minZ, maxZ));
            needNewGoal = false;

            transform.LookAt(currentGoal, Vector3.up);

        }

        if (eatTimer < 0)
        {
            Destroy(gameObject);
        }
        else
        {
            eatTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("food"))
        {
            Destroy(other.gameObject);
            Instantiate(kiwiPrefab, new Vector3(0, transform.position.y, 0), kiwiPrefab.transform.rotation);
            eatTimer = eatIntervall;
        }
    }
}
