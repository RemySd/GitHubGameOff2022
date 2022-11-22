using UnityEngine;

public class KnifeItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("knife", 1);
            Destroy(gameObject);
        }
    }
}
