using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        PlayerEvents.instance.onPlayerDie += (callerObject) =>
        {
            PlayerAnimation playerAnimation = GetComponentInChildren<PlayerAnimation>();
            playerAnimation.RunDeath();

            ServiceLocator.GetInstance().GetEffectService().RunSpikeEffect(callerObject);
        };
    }
}
