using UnityEngine;

public class BookItem : MonoBehaviour
{
    [SerializeField] private GameObject spriteObject;
    [SerializeField] private GameObject interactiveArea;
    [SerializeField] private ParticleSystem bookParticle;

    [SerializeField] private GameObject credit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SfxSource.instance.PlayKnifePickUp();
            spriteObject.SetActive(false);
            interactiveArea.SetActive(false);
            bookParticle.Stop();

            credit.SetActive(true);
        }
    }
}
