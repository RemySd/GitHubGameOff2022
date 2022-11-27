using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogPanelService : MonoBehaviour, IService
{
    public const string NAME = "DialogPanel";

    private DialogPanelContainer dialogPanelContainer;

    private Queue<string> sentences;

    private void Awake()
    {
        sentences = new Queue<string>();
    }

    private void Start()
    {
        dialogPanelContainer = GameObject.FindGameObjectWithTag("DialogPanel").GetComponent<DialogPanelContainer>();
    }

    public string GetName()
    {
        return NAME;
    }

    public void InitDialog(Dialog dialog)
    {
        dialogPanelContainer.dialogImage.sprite = dialog.dialogImage;

        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        dialogPanelContainer.DisplayDialogPanel();

        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentences(sentence));
    }

    IEnumerator TypeSentences(string sentence)
    {
        dialogPanelContainer.dialogText.text = "";
        foreach (char letter in sentence)
        {
            if (letter != ' ')
            {
                SfxSource.instance.PlayDialog();
            }
            
            dialogPanelContainer.dialogText.text += letter;
            yield return new WaitForSeconds(0.055f);
        }
    }

    private void EndDialog()
    {
        // disable dialog UI
        dialogPanelContainer.HideDialogPanel();
    }

    public bool IsReady()
    {
        return sentences.Count > 0;
    }
}
