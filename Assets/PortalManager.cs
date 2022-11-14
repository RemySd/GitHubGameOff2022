using UnityEngine;

public class PortalManager : MonoBehaviour
{
    [SerializeField] private new GameObject particleSystem;
    [SerializeField] private new GameObject collider;

    public void EnablePortal()
    {
        particleSystem.SetActive(true);
        collider.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // switch scene
        }
    }
}
