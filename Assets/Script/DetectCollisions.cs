using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is 
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        if (playerController == null)
        {
            Debug.LogError("Nie znaleniono gracza");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Zderzenie z: " + other.gameObject.name + ", tag: " + other.tag);

        if (other.CompareTag("Food"))
        {
            Debug.Log("Kolizja z jedzeniem niszczę oba");
            Destroy(gameObject);             // Zniszcz zwierzę
            Destroy(other.gameObject);      // Zniszcz jedzenie
            playerController.GetScore();
            Debug.Log($"twój wynik to: {playerController.score}");
        }
        else if (other.CompareTag("Animal_1"))
        {
            // NIC nie rób: ani zwierzę, ani gracz nie są niszczeni
            Debug.Log("Kolizja z graczem lub innym zwierzęciem brak działania");
        }
        else if (other.CompareTag("Player"))
        {
            Debug.Log("Kolizja z graczem");
            playerController.LoseHp();
            Debug.Log($"zostało ci: {playerController.life} żyć");
        }
        else
        {
            // Jeśli kolizja z czymś innym (np. ścianą), zniszcz zwierzę
            Debug.Log("Kolizja z czymś innym niszczę zwierzę");
            Destroy(gameObject);
        }
    }
}


