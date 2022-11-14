using UnityEngine;

public class BlockBuilder : MonoBehaviour
{
    private GameObject[] blocks;

    [SerializeField] private float xGap;
    [SerializeField] private float yGap;

    private void Start()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");

        BuildBlocksAdjacents();
        RuleCheck();
    }

    public void RuleCheck()
    {
        foreach (GameObject block in blocks)
        {
            BlockAttribute blockAttribute = block.GetComponent<BlockAttribute>();

            if (blockAttribute.GetAdjacentByColor("green").Count < 2 && blockAttribute.GetColor() == "red")
            {
                blockAttribute.SetIsMortal(true);
            }
        }
    }

    public void BuildBlocksAdjacents()
    {
        foreach (GameObject block in blocks)
        {
            BlockAttribute blockAttribute = block.GetComponent<BlockAttribute>();
            blockAttribute.SetLeftAdjacent(GetLeftAdjacent(block));
            blockAttribute.SetRightAdjacent(GetRightAdjacent(block));
            blockAttribute.SetTopAdjacent(GetTopAdjacent(block));
            blockAttribute.SetBottomAdjacent(GetBottomAdjacent(block));
        }
    }

    private GameObject GetLeftAdjacent(GameObject currentBlock)
    {
        float xAdjacent = currentBlock.transform.position.x - xGap;
        float yAdjacent = currentBlock.transform.position.y + yGap;

        return GetBlockByPosition(xAdjacent, yAdjacent);
    }

    private GameObject GetRightAdjacent(GameObject currentBlock)
    {
        float xAdjacent = currentBlock.transform.position.x + xGap;
        float yAdjacent = currentBlock.transform.position.y - yGap;

        return GetBlockByPosition(xAdjacent, yAdjacent);
    }

    private GameObject GetTopAdjacent(GameObject currentBlock)
    {
        float xAdjacent = currentBlock.transform.position.x + xGap;
        float yAdjacent = currentBlock.transform.position.y + yGap;

        return GetBlockByPosition(xAdjacent, yAdjacent);
    }

    private GameObject GetBottomAdjacent(GameObject currentBlock)
    {
        float xAdjacent = currentBlock.transform.position.x - xGap;
        float yAdjacent = currentBlock.transform.position.y - yGap;

        return GetBlockByPosition(xAdjacent, yAdjacent);
    }

    private GameObject GetBlockByPosition(float x, float y)
    {
        x = RoundNumber(x);
        y = RoundNumber(y);

        foreach (GameObject otherBlock in blocks)
        {
            float otherBlockX = RoundNumber(otherBlock.transform.position.x);
            float otherBlockY = RoundNumber(otherBlock.transform.position.y);

            if (otherBlockX == x && otherBlockY == y)
            {
                return otherBlock;
            }
        }

        return null;
    }

    private float RoundNumber(float numberToRound)
    {
        return (float) (Mathf.Round(numberToRound * 100) / 100.0);
    }
}
