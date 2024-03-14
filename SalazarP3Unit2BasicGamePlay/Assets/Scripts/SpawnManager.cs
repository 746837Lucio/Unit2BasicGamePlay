using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreFabs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            int animalIndex = Random.Range(0, animalPreFabs.Length);
            Instantiate(animalPreFabs[animalIndex], new Vector3(0, 0, 20),
                    animalPreFabs[animalIndex].transform.rotation);
        

        
    }
}
