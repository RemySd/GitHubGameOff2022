using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] private int lifePoint = 50;
    [SerializeField] private SpriteRenderer eyeSpriteRenderer;
    [SerializeField] private GameObject orbz;
    [SerializeField] private GameObject orbzSpawn;

    [SerializeField] private Animator transitionAnimator;

    private Animator bossAnimator;

    [SerializeField]
    private bool canInvokeAttack = false;

    private float nextActionTime;

    [SerializeField]
    private float period;

    private void Start()
    {
        nextActionTime = Time.time;

        canInvokeAttack = false;
        bossAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Time.time > nextActionTime && canInvokeAttack)
        {
            nextActionTime = Time.time + period;
            Instantiate(orbz, orbzSpawn.transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Knife") && canInvokeAttack)
        {
            SfxSource.instance.PlayEnemyHit();

            StartCoroutine(HitEye());

            lifePoint--;

            if (lifePoint <= 0)
            {
                canInvokeAttack = false;
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
            if (i%5 == 0)
            {
                SfxSource.instance.PlayBossExplosion();
            }

            yield return new WaitForSeconds(0.1f);
            ServiceLocator.GetInstance().GetCameraService().Shake();
            ServiceLocator.GetInstance().GetEffectService().RunExplosionEffect(explosionSpawn[Random.Range(0, 6)]);
        }

        bossAnimator.SetTrigger("DeathBoss");

        yield return new WaitForSeconds(2f);

        transitionAnimator.SetTrigger("RunTransition");
    }

    public void EnableBossAttack()
    {
        bossAnimator.SetTrigger("StartBoss");
        StartCoroutine(StartAttack());
    }

    private IEnumerator StartAttack()
    {
        yield return new WaitForSeconds(2.5f);
        canInvokeAttack = true;
    }
}
