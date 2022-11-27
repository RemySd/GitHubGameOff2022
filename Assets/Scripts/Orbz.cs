using UnityEngine;
using UnityEngine.SceneManagement;

public class Orbz : MonoBehaviour
{
    private Vector3 movement;

    [SerializeField] private float speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TransitionEvents.instance.onCloseTransitionTriggerDone += () =>
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            };

            PlayerEvents.instance.OnPlayerDie(null);
        }
    }

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        movement = (player.transform.position - transform.position).normalized;
    }

    private void FixedUpdate()
    {
        transform.Translate(movement * Time.deltaTime * speed);
    }
}
