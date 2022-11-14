using System;
using UnityEngine;

public class TransitionEvents : MonoBehaviour
{
    public static TransitionEvents instance;

    private void Awake()
    {
        if (instance)
        {
            return;
        }

        instance = this;
    }

    public event Action onCloseTransitionTriggerDone;
    public void CloseTransitionTriggerDone()
    {
        if (onCloseTransitionTriggerDone != null)
        {
            onCloseTransitionTriggerDone();
        }
    }

    public event Action onOpenTransitionTriggerDone;
    public void OpenTransitionTriggerDone()
    {
        if (onOpenTransitionTriggerDone != null)
        {
            onOpenTransitionTriggerDone();
        }
    }
}
