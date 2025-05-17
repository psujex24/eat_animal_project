using UnityEditor.Animations;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public PlayerController playerController;
    public int maxHealth = 3;
    public int currentHealth;

    public HPBar healthbar;

    // Start is called once before the first execution of Update after the MonoBehaviour is 
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Zderzenie z: " + other.gameObject.name + ", tag: " + other.tag);

        if (other.CompareTag("Food"))
        {
            TakeDamage(1);          // Zniszcz zwierzę
            Destroy(other.gameObject);      // Zniszcz jedzenie

        }
        else if (other.CompareTag("Animal_1"))
        {
            // NIC nie rób: ani zwierzę, ani gracz nie są niszczeni
        }
        else if (other.CompareTag("Player"))
        {
            playerController.LoseHp();
            Debug.Log($"zostało ci: {playerController.life} żyć");
        }
        else
        {
            // Jeśli kolizja z czymś innym (np. ścianą), zniszcz zwierzę
            Destroy(gameObject);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            playerController.GetScore();
            Debug.Log($"twój wynik to: {playerController.score}");

        }
    }
}


