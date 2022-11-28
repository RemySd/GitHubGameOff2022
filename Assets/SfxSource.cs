using UnityEngine;

public class SfxSource : MonoBehaviour
{
    [SerializeField] private AudioClip deathAudio;
    [SerializeField] private AudioClip dialogAudio;
    [SerializeField] private AudioClip stelePressAudio;
    [SerializeField] private AudioClip transitionAudio;
    [SerializeField] private AudioClip knifePickUpAudio;
    [SerializeField] private AudioClip knifeThrowAudio;
    [SerializeField] private AudioClip interuptor1Audio;
    [SerializeField] private AudioClip interuptor2Audio;
    [SerializeField] private AudioClip enemyHitAudio;
    [SerializeField] private AudioClip bossExplosionAudio;

    private AudioSource audioSource;

    public static SfxSource instance;

    private void Awake()
    {
        if (instance)
        {
            return;
        }

        instance = this;
    }

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayDeath()
    {
        PlaySfx(deathAudio, 0.5f);
    }

    public void PlayDialog()
    {
        PlaySfx(dialogAudio, 0.2f);
    }

    public void PlayStelePress()
    {
        PlaySfx(stelePressAudio, 0.2f);
    }

    public void PlayTransition()
    {
        PlaySfx(transitionAudio, 0.2f);
    }

    public void PlayKnifePickUp()
    {
        PlaySfx(knifePickUpAudio, 0.2f);
    }

    public void PlayKnifeThrow()
    {
        PlaySfx(knifeThrowAudio, 0.2f);
    }

    public void PlayInteruptor1()
    {
        PlaySfx(interuptor1Audio, 0.2f);
    }

    public void PlayInteruptor2()
    {
        PlaySfx(interuptor2Audio, 0.2f);
    }

    public void PlayEnemyHit()
    {
        PlaySfx(enemyHitAudio, 0.2f);
    }

    public void PlayBossExplosion()
    {
        PlaySfx(bossExplosionAudio, 0.2f);
    }

    public void PlaySfx(AudioClip customAudioClip, float volume)
    {
        audioSource.PlayOneShot(customAudioClip, volume);
    }
}
