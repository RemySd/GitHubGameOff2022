using UnityEngine;

public class BlockAttribute : MonoBehaviour
{
    [SerializeField] private string color;

    [SerializeField] private GameObject leftAdjacent;
    [SerializeField] private GameObject rightAdjacent;
    [SerializeField] private GameObject topAdjacent;
    [SerializeField] private GameObject bottomAdjacent;

    // void Start()
    // {
    //     GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");
    // 
    //     // Check left border
    //     foreach (GameObject block in blocks)
    //     {
    //         // Debug.Log(block.transform.position.x);
    //         
    //         // Should be convert to float for a correct comparaison
    //         float xLeftAdjacent = (float) (Mathf.Round((transform.position.x - 0.16f) * 100) / 100.0);
    //         float yLeftAdjacent = (float) (Mathf.Round((transform.position.y + 0.08f) * 100) / 100.0);
    // 
    //         if (block.transform.position.x == xLeftAdjacent && block.transform.position.y == yLeftAdjacent)
    //         {
    //             leftAdjacent = block;
    //         }
    //     }
    // }

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
}
