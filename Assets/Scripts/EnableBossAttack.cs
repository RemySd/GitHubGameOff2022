using UnityEngine;

public class EnableBossAttack : MonoBehaviour
{
    [SerializeField]
    private Boss bossScript;

    private bool stepDone;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && stepDone == false)
        {
            stepDone = true;
            bossScript.EnableBossAttack();
        }
    }
}
