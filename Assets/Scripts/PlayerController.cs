using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; //rigidbody da bola

    [Header("Player Settings")] //header para as configurações da bola
    public float playerSpeed = 3f; //controla a velocidade da bola
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal"); //pega o movimento horizontal da bola
        float verticalMovement = Input.GetAxis("Vertical"); //pega o movimento vertical da bola
        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement); //cria um vetor de movimento onde o X e Y são o movimento horizontal e vertical respectivamente.

        playerRb.AddForce(movement * playerSpeed); //adiciona força no rigidbody da bola multiplicado com a velocidade dela
    }
}
