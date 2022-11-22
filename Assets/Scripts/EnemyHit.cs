using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TransitionEvents.instance.onCloseTransitionTriggerDone += () =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            };

            PlayerEvents.instance.OnPlayerDie(null);
        }

        if (collision.CompareTag("Knife"))
        {
            ServiceLocator.GetInstance().GetEffectService().RunExplosionEffect(gameObject);

            Destroy(gameObject);
        }
    }
}
