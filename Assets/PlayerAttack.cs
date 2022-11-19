using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject knifePrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(knifePrefab, transform.position, Quaternion.identity);
        }
    }
}
