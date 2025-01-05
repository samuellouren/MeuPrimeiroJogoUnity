using UnityEngine;

public class Moedas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Object.FindAnyObjectByType<GameManager>().moedasNaFase += 1;
    }

    void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.CompareTag("Player"))
         {
             Object.FindAnyObjectByType<GameManager>().DescontarMoedas();
            Destroy(this.gameObject);
         }
    }
}