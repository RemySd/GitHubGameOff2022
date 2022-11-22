using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject knifePrefab;
    [SerializeField] private GameObject knifeSpawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && PlayerPrefs.GetInt("knife", 0) > 0)
        {
            Instantiate(knifePrefab, knifeSpawnPoint.transform.position, Quaternion.identity);
        }
    }
}
