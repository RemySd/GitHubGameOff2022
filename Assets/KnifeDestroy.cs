using UnityEngine;

public class KnifeDestroy : MonoBehaviour
{
    [SerializeField] private GameObject effectSpawnpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ServiceLocator.GetInstance().GetEffectService().RunExplosionEffect(effectSpawnpoint);

        Destroy(gameObject);
    }
}
