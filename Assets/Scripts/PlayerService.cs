using UnityEngine;

public class PlayerService : MonoBehaviour, IService
{
    public const string NAME = "Player";

    public string GetName()
    {
        return NAME;
    }

    private PlayerMovementV2 playerMovement;
    private GameObject playerGameObject;

    public void Init()
    {
        playerGameObject = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerGameObject.GetComponent<PlayerMovementV2>();
    }

    public void DisablePlayerMovement()
    {
        playerMovement.isStop = true;
    }

    public void EnablePlayerMovement()
    {
        playerMovement.isStop = false;
    }

    public GameObject GetPlayer()
    {
        if (playerGameObject == null)
        {
            playerGameObject = GameObject.FindGameObjectWithTag("Player");
        }

        return playerGameObject;
    }
}
