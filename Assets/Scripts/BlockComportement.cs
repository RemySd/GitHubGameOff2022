using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockComportement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isPressed = false;

    [SerializeField] private Sprite pressedBlock;
    [SerializeField] private GameObject spikeEffects;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isPressed)
        {
            SfxSource.instance.PlayStelePress();
            isPressed = true;

            spriteRenderer.sprite = pressedBlock;

            BlockAttribute blockAttribute = GetComponent<BlockAttribute>();

            if (blockAttribute.isMortal)
            {
                TransitionEvents.instance.onCloseTransitionTriggerDone += () =>
                {
                    Scene scene = SceneManager.GetActiveScene();
                    SceneManager.LoadScene(scene.name);
                };

                PlayerEvents.instance.OnPlayerDie(gameObject);
            }
        }
    }
}
