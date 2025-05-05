using TMPro;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreFabs;
    public int animalIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPreFabs[animalIndex], new Vector3(0, 0, 20), animalPreFabs[animalIndex].transform.rotation);
        }
    }
}
