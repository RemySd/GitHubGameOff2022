using UnityEngine;

public class RulesBoard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ServiceLocator.GetInstance().GetUiService().DisplayRulesBoard();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ServiceLocator.GetInstance().GetUiService().HideRulesBoard();
        }
    }
}
