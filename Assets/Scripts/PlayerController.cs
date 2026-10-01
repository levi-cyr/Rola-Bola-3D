using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; //rigidbody da bola
    private int count; //contagem dos porcos coletados
    public TextMeshProUGUI countText;
    public GameObject winTextObject; //texto de vitoria
    public AudioSource pigDyingAudio; //fonte do audio

    [Header("Player Settings")] //header para as configurações da bola
    public float playerSpeed = 3f; //controla a velocidade da bola
    void Start()
    {
        count = 0;
        playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal"); //pega o movimento horizontal da bola
        float verticalMovement = Input.GetAxis("Vertical"); //pega o movimento vertical da bola
        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement); //cria um vetor de movimento onde o X e Y são o movimento horizontal e vertical respectivamente.

        playerRb.AddForce(movement * playerSpeed); //adiciona força no rigidbody da bola multiplicado com a velocidade dela

        SetCountText(); //
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            pigDyingAudio.Play(); //toca o audio
        }
    }
    

    void SetCountText()
    {
        countText.text = "Carnes: " + count.ToString();
        if (count >= 6) //se a contagem de pontos for maior ou igual a 6, ele ativa o texto de vitoria
            winTextObject.SetActive(true);
    }
}
