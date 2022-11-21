using UnityEngine;

public class EffectService : MonoBehaviour, IService
{
    public const string NAME = "Effect";

    [SerializeField] private GameObject spikeEffectPrefab;
    [SerializeField] private GameObject explosionEffectPrefab;

    public string GetName()
    {
        return NAME;
    }

    public void RunSpikeEffect(GameObject parentGameObject)
    {
        GameObject spikes = Instantiate(spikeEffectPrefab, Vector2.zero, Quaternion.identity);
        spikes.transform.parent = parentGameObject.transform;
        spikes.transform.position = parentGameObject.transform.position + new Vector3(0f, 0.05f);
        spikes.GetComponent<Animator>().Rebind();
    }

    public void RunExplosionEffect(GameObject parentGameObject)
    {
        GameObject explosionEffect = Instantiate(explosionEffectPrefab, Vector2.zero, Quaternion.identity);
        explosionEffect.transform.position = parentGameObject.transform.position;
    }
}

