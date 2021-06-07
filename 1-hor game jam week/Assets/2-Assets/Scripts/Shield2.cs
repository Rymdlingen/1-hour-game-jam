using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield2 : MonoBehaviour
{
    public Material[] materials;
    private int currentMaterial = 0;

    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = materials[currentMaterial];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentMaterial++;
            if (currentMaterial > materials.Length - 1)
            {
                currentMaterial = 0;
            }

            meshRenderer.sharedMaterial = materials[currentMaterial];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy1"))
        {
            if (currentMaterial == 0)
            {
                other.gameObject.GetComponent<MoveEnemy2>().shouldMove = false;
            }
            else
            {

            }
        }
        else if (other.gameObject.CompareTag("Enemy2"))
        {
            if (currentMaterial == 1)
            {
                other.gameObject.GetComponent<MoveEnemy2>().shouldMove = false;
            }
            else
            {

            }
        }
        else if (other.gameObject.CompareTag("Enemy3"))
        {
            if (currentMaterial == 2)
            {
                other.gameObject.GetComponent<MoveEnemy2>().shouldMove = false;
            }
            else
            {

            }
        }
    }
}
