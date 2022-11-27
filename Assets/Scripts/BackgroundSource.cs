using System.Collections;
using UnityEngine;

public class BackgroundSource : MonoBehaviour
{
    [SerializeField] private AudioClip gameAudio;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void Start()
    {
        StartCoroutine(CheckAudioToLoad());
    }

    public IEnumerator CheckAudioToLoad()
    {
        if (audioSource.clip != gameAudio)
        {
            StartCoroutine(StartFade(audioSource, 0.6f, 0));
            yield return new WaitForSeconds(0.6f);
            audioSource.clip = gameAudio;
            audioSource.Play();
            StartCoroutine(StartFade(audioSource, 0.6f, 0.3f));
        }

        yield return null;
    }

    public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}
