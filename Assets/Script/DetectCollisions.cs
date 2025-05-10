using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        // Sprawdzamy, czy kolizja jest z jedzeniem (steakiem)
        if (other.CompareTag("Food_Steak_01"))
        {
            Debug.Log("Game Over! Pizze zniszczone!");
            Destroy(gameObject);  // Zniszczenie zwierzęcia
            Destroy(other.gameObject);  // Zniszczenie steak (jedzenie)
        }
        // Sprawdzamy, czy kolizja jest z gracza (jeśli chcesz mieć specjalną logikę dla gracza)
        else if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over! Gracz zniszczony!");
            Destroy(gameObject);  // Zniszczenie zwierzęcia
        }
        // Sprawdzamy kolizję z innymi zwierzętami - nie robimy nic w tym przypadku
        else if (other.CompareTag("Animal_Stag_02") || other.CompareTag("Animal_Fox_02") || other.CompareTag("Animal_Doe_02"))
        {
            // Zwierzęta nie niszczą siebie nawzajem, więc nic się nie dzieje
        }
        // W przeciwnym razie, niszczymy obiekt, jeśli to nie jest zwierzę ani steak
        else
        {
            Destroy(gameObject);
        }
    }

}
