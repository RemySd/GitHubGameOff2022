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
            isPressed = true;

            spriteRenderer.sprite = pressedBlock;

            BlockAttribute blockAttribute = GetComponent<BlockAttribute>();

            if (blockAttribute.isMortal)
            {
                PlayerAnimation playerAnimation = collision.gameObject.GetComponentInChildren<PlayerAnimation>();
                playerAnimation.RunDeath();

                GameObject spikes = Instantiate(spikeEffects, Vector2.zero, Quaternion.identity);
                spikes.transform.parent = transform;
                spikes.transform.position = transform.position + new Vector3(0f, 0.05f);
                spikes.GetComponent<Animator>().Rebind();

                ServiceLocator.GetInstance().GetCameraService().Shake();

                // Scene scene = SceneManager.GetActiveScene();
                // SceneManager.LoadScene(scene.name);
            }
        }
    }
}
