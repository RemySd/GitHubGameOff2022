using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private void Start()
    {
        PlayerEvents.instance.onPlayerDie += (gameObject) =>
        {
            ServiceLocator.GetInstance().GetCameraService().Shake();
        };
    }
}
