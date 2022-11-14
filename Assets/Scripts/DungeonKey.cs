using UnityEngine;

public class DungeonKey : MonoBehaviour
{
    [SerializeField] private GameObject doorToOpen;
    [SerializeField] private float duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ServiceLocator.GetInstance().GetCameraService().FocusToOther(doorToOpen, duration);

            Destroy(gameObject);
        }
    }
}
