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
        openTransition.transform.position = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
        // openTransition.GetComponent<Animator>().Rebind();
    }

    public void RunCloseTransition()
    {
        GameObject closeTransition = Instantiate(closeTransitionPrefab, Vector3.zero, Quaternion.identity);
        //closeTransition.transform.position = Camera.main.transform.position;
        closeTransition.transform.position = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
    }
}

