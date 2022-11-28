using UnityEngine;

public class PortalInterruptor : MonoBehaviour
{
    private bool isTrigger = false;

    [SerializeField] private PortalManager portal;
    [SerializeField] private GameObject UIButtonX;
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite interruptorEnable;

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("Player") && !portal.isEnable())
        {
            isTrigger = true;
            UIButtonX.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !portal.isEnable())
        {
            isTrigger = false;
            UIButtonX.SetActive(false);
        }
    }

    private void Update()
    {
        if (isTrigger && Input.GetKeyDown(KeyCode.X) && !portal.isEnable())
        {
            SfxSource.instance.PlayInteruptor1();

            spriteRenderer.sprite = interruptorEnable;
            portal.EnablePortal();
            ServiceLocator.GetInstance().GetCameraService().FocusToOther(portal.gameObject, 3f, 0.3f);

            isTrigger = false;
            UIButtonX.SetActive(false);
        }
    }
}
