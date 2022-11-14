using UnityEngine;

public class CloseTransition : MonoBehaviour
{
    public void CloseAnimationDone()
    {
        TransitionEvents.instance.CloseTransitionTriggerDone();
    }
}
