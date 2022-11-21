using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Vector3 velocity;

    [SerializeField] private float distToAttack;
    [SerializeField] private float speed;

    private bool followPlayer;

    private GameObject playerGameObject;

    private void Start()
    {
        playerGameObject = ServiceLocator.GetInstance().GetPlayerService().GetPlayer();
    }

    private void Update()
    {
        if (followPlayer)
        {
            transform.position = Vector3.SmoothDamp(transform.position, playerGameObject.transform.position, ref velocity, speed);
            return;
        }

        float dist = Vector3.Distance(playerGameObject.transform.position, transform.position);

        if (dist < distToAttack)
        {
            followPlayer = true;
        }
    }
}
