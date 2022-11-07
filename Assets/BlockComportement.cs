using UnityEngine;

public class BlockComportement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isPressed = false;

    [SerializeField] private Sprite pressedBlock;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isPressed)
        {
            isPressed = true;
            spriteRenderer.sprite = pressedBlock;
        }
    }
}
