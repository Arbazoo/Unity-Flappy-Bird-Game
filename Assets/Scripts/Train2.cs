using UnityEngine;
using System.Collections;

public class Train2 : MonoBehaviour
{
    public float speed = 5f; // Speed at which the Train moves
    public float resetPositionX = 12f; // X position at which the Train will reset
    public float startPositionX = -5f; // X position at which the Train will start
    public float resetDelay = 4.0f; // Delay in seconds before the Train resets

    void Update()
    {
        // Move the Train to the right if it's not resetting
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // If the Train moves past the reset position, start the reset coroutine
        if (transform.position.x > resetPositionX)
        {
            StartCoroutine(ResetPositionAfterDelay());
        }
    }

    IEnumerator ResetPositionAfterDelay()
    {
        yield return new WaitForSeconds(resetDelay); // Wait for the specified delay
        transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z); // Reset the position
    }
}
