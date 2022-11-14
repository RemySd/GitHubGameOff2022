using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        ServiceLocator.GetInstance().GetTransitionService().RunOpenTransition();
    }
}
