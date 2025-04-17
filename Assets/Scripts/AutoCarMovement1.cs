using UnityEngine;

public class AutoCarMovement1 : MonoBehaviour
{
    public float speed = 4f; // Adjust speed as needed
    private Vector3 startPosition;
    private float distanceToMove = 100f; // 200 meters
    private bool isMoving = true;

    void Start()
    {
        startPosition = transform.position; // Record starting position
    }

    void Update()
    {
        if (isMoving)
        {
            // Move the car forward (in its local Z-axis)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            // Check if the car has traveled 200 meters
            if (Vector3.Distance(startPosition, transform.position) >= distanceToMove)
            {
                isMoving = false; // Stop moving
                Debug.Log("Car reached 200 meters!");
            }
        }
    }
}