using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerScript;
    private Vector3 cameraMovement;
    void Start()
    {
        cameraMovement = transform.position;
    }

    void Update()
    {
        transform.position = playerScript.transform.position + cameraMovement;
    }
}
