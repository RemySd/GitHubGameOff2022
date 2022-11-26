using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteTransitionBoss : MonoBehaviour
{
    public void FinalScene()
    {
        SceneManager.LoadScene("LevelEnd");
    }
}
