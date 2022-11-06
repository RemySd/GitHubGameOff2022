using UnityEngine;

public class TestGetCell : MonoBehaviour
{
    private void Start()
    {
        Grid grid = GetComponent<Grid>();
        Vector2 test = new Vector2(1.44f, 0.52f);
        Vector3Int cellPosition = grid.WorldToCell(test);
        // transform.position = grid.GetCellCenterWorld(cellPosition);
        Debug.Log(grid.GetCellCenterWorld(cellPosition));
    }
}
