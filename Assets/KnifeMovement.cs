using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMovement : MonoBehaviour
{
    private Quaternion rotation;

    private new Rigidbody2D rigidbody2D;

    private Vector3 movement;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        movement = FindObjectOfType<PlayerAnimation>().normalizeDir;

        float zDir = Mathf.Atan2(movement.x, movement.y);
        rotation = Quaternion.Euler(0, 0, zDir * Mathf.Rad2Deg + 45);
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
        transform.rotation = rotation;
    }

    public void SetDirection()
    {
        if (Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0 || Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
        {
            float zDir = Mathf.Atan2(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));
            // graphic.transform.rotation = Quaternion.RotateTowards(graphic.transform.rotation, Quaternion.Euler(0, 0, zDir * Mathf.Rad2Deg - 45), rotationSpeed * Time.fixedDeltaTime);
            //rotation = Quaternion.RotateTowards(graphic.transform.rotation, Quaternion.Euler(0, 0, zDir * Mathf.Rad2Deg - 45), rotationSpeed * Time.fixedDeltaTime);
        }
    }
}
