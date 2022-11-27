using UnityEngine;

public class SfxManager : MonoBehaviour
{
    [SerializeField] private GameObject sfxSource;

    void Start()
    {
        GameObject currentSfxSource = GameObject.FindGameObjectWithTag("SfxSource");

        if (!currentSfxSource)
        {
            DontDestroyOnLoad(Instantiate(sfxSource));
        }
    }
}
