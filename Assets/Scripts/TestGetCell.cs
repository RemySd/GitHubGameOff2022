using UnityEngine;

public class TestGetCell : MonoBehaviour
{
    private GameObject[] blocks;

    private void Start()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");
    }

    //public GameObject[] GetAdjacentBlocks()
    //{
    //
    //}
}
