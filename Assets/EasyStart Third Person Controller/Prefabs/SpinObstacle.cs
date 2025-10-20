using UnityEngine;

public class SpinObstacle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;

    void Update()
    {
        // Rotate around Z-axis
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}