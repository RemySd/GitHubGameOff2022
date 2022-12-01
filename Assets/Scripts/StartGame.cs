using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            TransitionEvents.instance.onCloseTransitionTriggerDone += () =>
            {
                SceneManager.LoadScene("Tutorial1");
            };

            ServiceLocator.GetInstance().GetTransitionService().RunCloseTransition();
        }
    }
}
