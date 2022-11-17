using UnityEngine;
using UnityEngine.UI;

public class DialogPanelContainer : MonoBehaviour
{
    [SerializeField] private GameObject dialogPanel;
    public Text dialogText;
    public Image dialogImage;

    public void DisplayDialogPanel()
    {
        if (!dialogPanel.activeSelf)
        {
            dialogPanel.SetActive(true);
        }
    }

    public void HideDialogPanel()
    {
        dialogPanel.SetActive(false);
    }
}
