using UnityEngine;
using UnityEngine.UI;

public class RulesBoardUI : MonoBehaviour
{
    [SerializeField] private Text rulesText;

    public void SetRulesText(string newText)
    {
        rulesText.text = newText;
    }
}
