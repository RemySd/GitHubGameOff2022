using UnityEngine;

public class SfxSource : MonoBehaviour
{
    [SerializeField] private AudioClip deathAudio;
    [SerializeField] private AudioClip dialogAudio;

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

    public void PlaySfx(AudioClip customAudioClip, float volume)
    {
        audioSource.PlayOneShot(customAudioClip, volume);
    }
}
