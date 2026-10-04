using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerObject; //gameObject do player
    public GameObject winScreen; //gameObject da gambiarra pra eu pegar a posição que quero que a camera olhe
    private Vector3 cameraMovement;
    public PlayerController playerController; //script do player
    void Start()
    {
        cameraMovement = transform.position;
    }

    void Update()
    {
        if (playerController.count >= 10)
        {
            transform.position = winScreen.transform.position + cameraMovement; //joga a camera para seguir o gameObject de vitoria
            transform.localEulerAngles = new Vector3(0, 0, 0); //seta os angulos da camera para 0 caso a contagem for igual ou maior que 10 (venceu o jogo)
        }
        else
        {
            transform.position = playerObject.transform.position + cameraMovement;
        }
    }
}
