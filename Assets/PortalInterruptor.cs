using UnityEngine;

public class PortalInterruptor : MonoBehaviour
{
    private bool isTrigger = false;

    [SerializeField] private PortalManager portal;
    [SerializeField] private GameObject UIButtonX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log("okok");
            isTrigger = true;
            UIButtonX.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTrigger = false;
            UIButtonX.SetActive(false);
        }
    }

    private void Update()
    {
        if (isTrigger && Input.GetKeyDown(KeyCode.X) && !portal.isEnable())
        {
            portal.EnablePortal();
        }
    }
}
