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
        if (SceneManager.GetActiveScene().name == "Level0")
        {
            return "Level1";
        }

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            return "Level2";
        }

        if (SceneManager.GetActiveScene().name == "Level2")
        {
            return "Level3";
        }

        if (SceneManager.GetActiveScene().name == "Level3")
        {
            return "Level4";
        }

        if (SceneManager.GetActiveScene().name == "Level4")
        {
            return "Boss";
        }

        if (SceneManager.GetActiveScene().name == "Tutorial2")
        {
            return "Level0";
        }

        return "";
    }
}
