using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelService : MonoBehaviour, IService
{
    public const string NAME = "Level";

    public string GetName()
    {
        return NAME;
    }

    public string GetNextLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            return "Level2";
        }

        return "";
    }
}