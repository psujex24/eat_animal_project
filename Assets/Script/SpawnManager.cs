using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float spawnPosZ = 20;
    private float spawnPosX = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int direction = Random.Range(0, 3); //losowanie kierunku
        Vector3 spawnPos = Vector3.zero;
        Quaternion spawnRotation = Quaternion.identity; // domyślna rotacja

        switch (direction)
        {
            case 0: // GÓRA
                spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                spawnRotation = Quaternion.Euler(0, 180, 0); // skierowany w dół (na Z-)
                break;

            case 1: // LEWA
                spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));
                spawnRotation = Quaternion.Euler(0, 90, 0); // skierowany na prawo (na X+)
                break;

            case 2: // PRAWA
                spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
                spawnRotation = Quaternion.Euler(0, -90, 0); // skierowany na lewo (na X-)
                break;
        }

        int animalIndex = Random.Range(0, animalPrefabs.Length); //losowanie rodzaju zwierzaka
        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRotation);


    }
}
