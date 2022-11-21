using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject knifePrefab;
    [SerializeField] private GameObject knifeSpawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(knifePrefab, knifeSpawnPoint.transform.position, Quaternion.identity);
        }
    }
}
