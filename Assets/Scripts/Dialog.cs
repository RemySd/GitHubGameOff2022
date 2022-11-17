using UnityEngine;

[System.Serializable]
public class Dialog
{
    public Sprite dialogImage;

    [TextArea(3, 10)]
    public string[] sentences;
}