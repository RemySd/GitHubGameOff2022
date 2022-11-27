using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private GameObject backgroundMusic;

    void Start()
    {
        GameObject currentBgMusic = GameObject.FindGameObjectWithTag("BackgroundSource");

        if (currentBgMusic)
        {
            StartCoroutine(currentBgMusic.GetComponent<BackgroundSource>().CheckAudioToLoad());
            return;
        }

        DontDestroyOnLoad(Instantiate(backgroundMusic));
    }
}
