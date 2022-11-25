using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] private int lifePoint = 5;
    [SerializeField] private SpriteRenderer eyeSpriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Knife"))
        {
            StartCoroutine(HitEye());

            lifePoint--;

            if (lifePoint <= 0)
            {
                ServiceLocator.GetInstance().GetCameraService().FocusToOther(gameObject, 10f);
                StartCoroutine(RunRandomExplosion());
            }
        }
    }

    private IEnumerator HitEye()
    {
        eyeSpriteRenderer.color = (Color)(new Color32(255, 0, 0, 255));
        yield return new WaitForSeconds(0.1f);
        eyeSpriteRenderer.color = (Color)(new Color32(255, 255, 255, 255));
    }

    private IEnumerator RunRandomExplosion()
    {
        GameObject[] explosionSpawn = GameObject.FindGameObjectsWithTag("ExplosionSpawn");

        yield return new WaitForSeconds(0.25f);

        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.1f);
            ServiceLocator.GetInstance().GetCameraService().Shake();
            ServiceLocator.GetInstance().GetEffectService().RunExplosionEffect(explosionSpawn[Random.Range(0, 6)]);
        }
    }
}
