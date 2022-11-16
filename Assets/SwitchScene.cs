using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] private string nextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TransitionEvents.instance.onCloseTransitionTriggerDone += () =>
            {
                SceneManager.LoadScene(nextScene);
            };

            ServiceLocator.GetInstance().GetTransitionService().RunCloseTransition();
        }
    }
}
