using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundSource : MonoBehaviour
{
    [SerializeField] private AudioClip windAudio;
    [SerializeField] private AudioClip gameAudio;
    [SerializeField] private AudioClip bossAudio;

    private AudioSource audioSource;

    public static BackgroundSource instance;

    private void Awake()
    {
        if (instance)
        {
            return;
        }

        instance = this;

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void Start()
    {
        StartCoroutine(CheckAudioToLoad());
    }

    public IEnumerator CheckAudioToLoad()
    {
        if (audioSource.clip != GetAudioToPlay())
        {
            StartCoroutine(StartFade(audioSource, 0.6f, 0));
            yield return new WaitForSeconds(0.6f);
            audioSource.clip = GetAudioToPlay();
            if (audioSource.clip)
            {
                audioSource.Play();
            }
            StartCoroutine(StartFade(audioSource, 0.6f, 0.3f));
        }

        yield return null;
    }

    public void PlayBossBakcground()
    {
        audioSource.clip = bossAudio;
        audioSource.Play();
    }

    private AudioClip GetAudioToPlay()
    {
        if (SceneManager.GetActiveScene().name == "Boss")
        {
            return null;
        }

        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "Tutorial1" || SceneManager.GetActiveScene().name == "LevelEnd")
        {
            return windAudio;
        }

        return gameAudio;
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
