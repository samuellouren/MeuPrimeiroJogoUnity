using UnityEngine;

public class BolaDoPerigo : MonoBehaviour
{
      void Start()
    {
        Object.FindAnyObjectByType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.CompareTag("Player"))
        {
              Object.FindFirstObjectByType<GameManager>().ReiniciarPartida();
        }
    }
}
