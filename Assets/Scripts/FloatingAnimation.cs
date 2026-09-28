using UnityEngine;

public class FloatingAnimation : MonoBehaviour
{
    public float speed = 2f; //velocidade da animação
    public float height = 0.2f; //altura que o objeto vai flutuar
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; //pega a posição inicial do objeto e guarda na variavel
    }
    private void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height; 
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
