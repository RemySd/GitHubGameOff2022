using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalManager : MonoBehaviour
{
    [SerializeField] private new GameObject particleSystem;
    [SerializeField] private new GameObject collider;

    public void EnablePortal()
    {
        particleSystem.SetActive(true);
        collider.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ServiceLocator.GetInstance().GetPlayerService().DisablePlayerMovement();
            SfxSource.instance.PlayTransition();

            TransitionEvents.instance.onCloseTransitionTriggerDone += () =>
            {
                SceneManager.LoadScene(ServiceLocator.GetInstance().GetLevelService().GetNextLevel());
            };

            ServiceLocator.GetInstance().GetTransitionService().RunCloseTransition();
        }
    }

    public bool isEnable()
    {
        return particleSystem.activeSelf;
    }
}
