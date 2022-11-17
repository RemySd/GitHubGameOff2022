using UnityEngine;

public class PlayerService : MonoBehaviour, IService
{
    public const string NAME = "Player";

    public string GetName()
    {
        return NAME;
    }

    private PlayerMovementV2 playerMovement;

    public void Init()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementV2>();
    }

    public void DisablePlayerMovement()
    {
        playerMovement.isStop = true;
    }

    public void EnablePlayerMovement()
    {
        playerMovement.isStop = false;
    }
}
