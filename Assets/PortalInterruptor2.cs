using UnityEngine;

public class PortalInterruptor2 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite portalInterruptorEnable;

    private PortalManager portalManager;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        portalManager = GameObject.FindGameObjectWithTag("Portal").GetComponent<PortalManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ok");
        if (collision.CompareTag("Knife"))
        {
            Debug.Log("hit knife");
            portalManager.EnablePortal();
            ServiceLocator.GetInstance().GetCameraService().FocusToOther(portalManager.gameObject, 3f, 0.3f);

            spriteRenderer.sprite = portalInterruptorEnable;
        }
    }
}