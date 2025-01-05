using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public float velocidadeDoJogador;
    public Rigidbody oRigidbody;

    private float movimentoX;
    private float movimentoZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarBola();
    }

    private void MovimentarBola()
    {
        movimentoX = Input.GetAxis("Horizontal") * velocidadeDoJogador;
        movimentoZ = Input.GetAxis("Vertical") * velocidadeDoJogador;

        oRigidbody.AddForce(movimentoX, 0f, movimentoZ);

    }
}
