using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float lastSwapTime;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {


        if (Time.time - lastSwapTime > 1.0f)
        { //enough time has elapsed
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

                lastSwapTime = Time.time;
            }
        }
    }
}




