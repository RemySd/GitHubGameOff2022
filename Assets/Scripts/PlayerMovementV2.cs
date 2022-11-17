using UnityEngine;

public class PlayerMovementV2 : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    [SerializeField] private float moveSpeed = 1.0f;

    public bool dead;
    public bool isStop = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (isStop)
        {
            Vector2 stopVector = new Vector2(0, 0); ;
            FindObjectOfType<PlayerAnimation>().SetDirection(stopVector);
            return;
        }

        if (dead)
        {
            return;
        }

        Vector2 currentPos = rigidbody.position;

        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        if (moveH != 0 && moveV != 0)
        {
            moveV = moveV / 2;
        }

        Vector2 inputVector = new Vector2(moveH, moveV);

        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        Vector2 movement = inputVector * moveSpeed;

        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        rigidbody.MovePosition(newPos);

        FindObjectOfType<PlayerAnimation>().SetDirection(inputVector);
    }
}
