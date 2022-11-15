using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        ServiceLocator.GetInstance().GetTransitionService().RunOpenTransition();
    }
}
