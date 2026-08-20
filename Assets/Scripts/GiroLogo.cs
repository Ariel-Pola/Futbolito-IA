using UnityEngine;

public class RotateLogo : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 50, 0); // Velocidad de giro en grados por segundo

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
