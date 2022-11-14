using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEvents : MonoBehaviour
{
    public static PlayerEvents instance;

    private void Awake()
    {
        if (instance)
        {
            return;
        }

        instance = this;
    }

    public event Action<GameObject> onPlayerDie;
    public void OnPlayerDie(GameObject currentObject)
    {
        if (onPlayerDie != null)
        {
            onPlayerDie(currentObject);
        }
    }
}
