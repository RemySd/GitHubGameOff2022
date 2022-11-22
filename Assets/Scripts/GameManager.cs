using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            PlayerPrefs.SetInt("knife", 0);
        }

        ServiceLocator.GetInstance().GetTransitionService().RunOpenTransition();
    }
}
