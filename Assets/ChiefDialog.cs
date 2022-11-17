using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChiefDialog : MonoBehaviour
{
    [SerializeField] private Dialog chiefDialog;

    private bool isInRange;

    private bool isDone;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;

            ServiceLocator.GetInstance().GetPlayerService().DisablePlayerMovement();

            ServiceLocator.GetInstance().GetDialogPanelService().InitDialog(chiefDialog);
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
        if (Input.GetKeyDown(KeyCode.X) && isInRange)
        {
            if (!ServiceLocator.GetInstance().GetDialogPanelService().IsReady())
            {
                ServiceLocator.GetInstance().GetPlayerService().EnablePlayerMovement();
            }

            ServiceLocator.GetInstance().GetDialogPanelService().DisplayNextSentence();
        }
    }
}
