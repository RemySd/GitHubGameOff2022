using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private PlayerMovementV2 playerMovement;

    private Animator anim;

    public string[] staticDirections = { "IdleN", "IdleNW", "IdleW", "IdleSW", "IdleS", "IdleSE", "IdleE", "IdleNE" };
    public string[] runDirections = { "RunN", "RunNW", "RunW", "RunSW", "RunS", "RunSE", "RunE", "RunNE" };

    int lastDirection;

    public float angleSave;

    public Vector2 normalizeDir;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        float result1 = Vector2.SignedAngle(Vector2.up, Vector2.right);
        // Debug.Log("R1 " + result1);

        float result2 = Vector2.SignedAngle(Vector2.up, Vector2.left);
        // Debug.Log("R2 " + result2);

        float result3 = Vector2.SignedAngle(Vector2.up, Vector2.down);
        // Debug.Log("R3 " + result3);
    }

    //MARKER each direction will match with one string element
    //MARKER We used direction to determine their animation
    public void SetDirection(Vector2 _direction)
    {
        if (playerMovement.dead)
        {
            return;
        }

        string[] directionArray = null;

        if (_direction.magnitude < 0.01)//MARKER Character is static. And his velocity is close to zero
        {
            directionArray = staticDirections;
        }
        else
        {
            directionArray = runDirections;

            lastDirection = DirectionToIndex(_direction);//MARKER Get the index of the slcie from the direction vector
            //Debug.Log(lastDirection);
        }

        anim.Play(directionArray[lastDirection]);
    }

    //MARKER Converts a Vector2 direction to an index to a slcie around a circle
    //CORE this goes in a counter-clock direction
    private int DirectionToIndex(Vector2 _direction)
    {
        normalizeDir = _direction.normalized;//MARKER return this vector with a magnitude of 1 and get the normalized to an index

        float step = 360 / 8;//MARKER 45 one circle and 8 slices//Calcuate how many degrees one slice is 
        float offset = step / 2;//MARKER 22.5//OFFSET help us easy to calcuate and get the correct index of the string array

        float angle = Vector2.SignedAngle(Vector2.up, normalizeDir);//MARKER returns the signed angle in degrees between A and B

        angle += offset;//Help us easy to calcuate and get the correct index of the string array

        if (angle < 0)//avoid the negative number 
        {
            angle += 360;
        }

        angleSave = angle;

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }

    public void RunDeath()
    {
        playerMovement.dead = true;

        if (angleSave < 180)
        {
            anim.SetTrigger("DeathW");
        }
        else
        {
            anim.SetTrigger("DeathE");
        }
    }

    public void RunCloseTransition()
    {
        ServiceLocator.GetInstance().GetTransitionService().RunCloseTransition();
    }
}
