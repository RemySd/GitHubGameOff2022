using UnityEngine;

public class PortalInterruptor2 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite portalInterruptorEnable;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Knife"))
        {
            PortalManager portalManager = GameObject.FindGameObjectWithTag("Portal").GetComponent<PortalManager>();
            portalManager.EnablePortal();
            ServiceLocator.GetInstance().GetCameraService().FocusToOther(portalManager.gameObject, 3f, 0.3f);

            spriteRenderer.sprite = portalInterruptorEnable;
        }
    }
}
