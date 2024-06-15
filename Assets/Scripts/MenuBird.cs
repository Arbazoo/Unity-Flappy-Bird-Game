using UnityEngine;
using System.Collections;

public class MenuBird : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private int spriteIndex;
    public float defaultSpeed = 0.5f;
    public float moveSpeed = 2f; // Increased speed for moving right
    public float moveDuration = 1f; // Time in seconds to move in one direction
    public float delayBetweenMoves = 0.5f; // Delay between changes in direction
    private float animationInterval = 0.05f; // Default animation interval

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0)
        {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), animationInterval, animationInterval);
        StartCoroutine(MoveCoroutine());
    }

    private IEnumerator MoveCoroutine()
    {
        while (true)
        {
            // Move left
            float elapsedTime = -5f;
            while (elapsedTime < moveDuration)
            {
                transform.Translate(Vector3.left * defaultSpeed * Time.deltaTime);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // Wait for a delay
            yield return new WaitForSeconds(delayBetweenMoves);

            // Adjust animation speed for moving right
            CancelInvoke(nameof(AnimateSprite));
            InvokeRepeating(nameof(AnimateSprite), animationInterval / (moveSpeed / defaultSpeed), animationInterval / (moveSpeed / defaultSpeed));

            // Move right
            elapsedTime = -2f;
            while (elapsedTime < moveDuration)
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // Reset animation speed back to default
            CancelInvoke(nameof(AnimateSprite));
            InvokeRepeating(nameof(AnimateSprite), animationInterval, animationInterval);
        }
    }
}
