using UnityEngine;

public class DestroyOnExitAnimation : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private bool isParent = false;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Destroy"))
        {
            if (isParent)
            {
                Destroy(gameObject.transform.parent.gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }


}
