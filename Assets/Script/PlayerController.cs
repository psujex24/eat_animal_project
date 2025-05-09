using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zRange = 15.0f;


    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Update()
    {   //poruszanmie sie po osi x z "niewidzialna sciana"
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //poruszanie si epo osi z z "niewidzialna sciana"
        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        //wyłapywanmie klikniecia przyciskow
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //tempo ruchu 
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(moveDirection * speed * Time.deltaTime);
        //spawnowanie obiektow (steków)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
