using UnityEngine;

public class MoveBalloons : MonoBehaviour
{
    public float speed; // Speed at which the plane moves
    public float resetPositionX; // X position at which the plane will reset
    public float startPositionX; // X position at which the plane will start

    void FixedUpdate()
    {
        // Move the plane to the left
        transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);

        // If the plane moves past the reset position, move it back to the start position
        if (transform.position.x < resetPositionX)
        {
            transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
        }
    }
}
