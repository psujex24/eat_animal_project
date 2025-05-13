using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour


{
    public static int life = 3;
    private float topBound = 30;
    private float bottomBound = -30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
