using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 velocity;

    [SerializeField] private float timeOffset;
    [SerializeField] private Vector3 posOffset;
    [SerializeField] private float leftXPosLimit;
    [SerializeField] private float rightXPosLimit;

    [SerializeField] private GameObject objectToFollow;

    void Update()
    {
        if (objectToFollow)
        {
            float XPosClamp = Mathf.Clamp(objectToFollow.transform.position.x, leftXPosLimit, rightXPosLimit);
            Vector3 clampedTargetPos = new Vector3(
                XPosClamp,
                objectToFollow.transform.position.y,
                -10
                );

            transform.position = Vector3.SmoothDamp(transform.position, clampedTargetPos + posOffset, ref velocity, timeOffset);
        }
    }
}
