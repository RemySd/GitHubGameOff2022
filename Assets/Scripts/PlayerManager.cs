using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        PlayerEvents.instance.onPlayerDie += (callerObject) =>
        {
            SfxSource.instance.PlayDeath();

            PlayerAnimation playerAnimation = GetComponentInChildren<PlayerAnimation>();
            playerAnimation.RunDeath();

            if (callerObject)
            {
                ServiceLocator.GetInstance().GetEffectService().RunSpikeEffect(callerObject);
            }
        };
    }
}
