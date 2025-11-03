using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float obstacleSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obstacleSpeed = 8;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.linearVelocityX = -obstacleSpeed;
    }
}
