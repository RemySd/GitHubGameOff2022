using UnityEngine;

public class IntroDialog : MonoBehaviour
{
    [SerializeField] private Dialog introDialog;

    private bool isInRange;

    private bool isDone;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isDone)
        {
            isInRange = true;

            ServiceLocator.GetInstance().GetPlayerService().DisablePlayerMovement();

            ServiceLocator.GetInstance().GetDialogPanelService().InitDialog(introDialog);
            ServiceLocator.GetInstance().GetDialogPanelService().DisplayNextSentence();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && isInRange && !isDone)
        {
            if (!ServiceLocator.GetInstance().GetDialogPanelService().IsReady())
            {
                isDone = true;
                ServiceLocator.GetInstance().GetPlayerService().EnablePlayerMovement();
            }

            ServiceLocator.GetInstance().GetDialogPanelService().DisplayNextSentence();
        }
    }
}
