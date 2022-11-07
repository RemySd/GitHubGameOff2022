using System.Collections.Generic;
using UnityEngine;

public class BlockAttribute : MonoBehaviour
{
    public bool isMortal { get; private set; } = false;

    [SerializeField] private string color;

    [SerializeField] private GameObject leftAdjacent;
    [SerializeField] private GameObject rightAdjacent;
    [SerializeField] private GameObject topAdjacent;
    [SerializeField] private GameObject bottomAdjacent;

    public string GetColor()
    {
        return color;
    }

    public void SetLeftAdjacent(GameObject newLeftAdjacent)
    {
        leftAdjacent = newLeftAdjacent;
    }

    public void SetRightAdjacent(GameObject newRightAdjacent)
    {
        rightAdjacent = newRightAdjacent;
    }

    public void SetTopAdjacent(GameObject newTopAdjacent)
    {
        topAdjacent = newTopAdjacent;
    }

    public void SetBottomAdjacent(GameObject newBottomAdjacent)
    {
        bottomAdjacent = newBottomAdjacent;
    }

    public List<GameObject> GetAdjacentByColor(string color)
    {
        List<GameObject> greenAdjacents = new List<GameObject>();

        if (leftAdjacent && leftAdjacent.GetComponent<BlockAttribute>().GetColor() == color)
        {
            greenAdjacents.Add(leftAdjacent);
        }

        if (rightAdjacent && rightAdjacent.GetComponent<BlockAttribute>().GetColor() == color)
        {
            greenAdjacents.Add(rightAdjacent);
        }

        if (topAdjacent && topAdjacent.GetComponent<BlockAttribute>().GetColor() == color)
        {
            greenAdjacents.Add(topAdjacent);
        }

        if (bottomAdjacent && bottomAdjacent.GetComponent<BlockAttribute>().GetColor() == color)
        {
            greenAdjacents.Add(bottomAdjacent);
        }

        return greenAdjacents;
    }

    public void SetIsMortal(bool newIsMortal)
    {
        isMortal = newIsMortal;
    }
}
