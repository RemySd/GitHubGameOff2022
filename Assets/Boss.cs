using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] private int lifePoint = 50;
    [SerializeField] private SpriteRenderer eyeSpriteRenderer;
    [SerializeField] private GameObject orbz;
    [SerializeField] private GameObject orbzSpawn;

    private Animator bossAnimator;
    private bool canInvoke = false;

    private void Start()
    {
        canInvoke = false;
        bossAnimator = GetComponent<Animator>();

        InvokeRepeating("SpawnOrbz", 2f, 3f);
    }

    private void SpawnOrbz()
    {
        if (canInvoke)
        {
            Instantiate(orbz, orbzSpawn.transform.position, Quaternion.identity);
        }
    }

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
                canInvoke = false;
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

        bossAnimator.SetTrigger("DeathBoss");
    }
}
