using UnityEngine;

public class TransitionService : MonoBehaviour, IService
{
    public const string NAME = "Transition";

    [SerializeField]
    private GameObject openTransitionPrefab;

    [SerializeField]
    private GameObject closeTransitionPrefab;

    public string GetName()
    {
        return NAME;
    }

    public void RunOpenTransition()
    {
        GameObject openTransition = Instantiate(openTransitionPrefab, Vector3.zero, Quaternion.identity);
        openTransition.transform.parent = Camera.main.transform;
        openTransition.transform.localPosition = new Vector3(0, 0, 1);
    }

    public void RunCloseTransition()
    {
        GameObject closeTransition = Instantiate(closeTransitionPrefab, Vector3.zero, Quaternion.identity);
        closeTransition.transform.parent = Camera.main.transform;
        closeTransition.transform.localPosition = new Vector3(0, 0, 1);
    }
}
