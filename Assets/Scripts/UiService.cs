using UnityEngine;

public class UiService : MonoBehaviour, IService
{
    public const string NAME = "Ui";

    private GameObject rulesBoardUI;

    public string GetName()
    {
        return NAME;
    }

    void Start()
    {
        rulesBoardUI = GameObject.FindGameObjectWithTag("RulesBoard");
    }

    public void DisplayRulesBoard()
    {
        rulesBoardUI.GetComponent<Animator>().SetTrigger("RulesUp");
    }

    public void HideRulesBoard()
    {
        rulesBoardUI.GetComponent<Animator>().SetTrigger("RulesDown");
    }

    public void UpdateTextRulesBoard(string newText)
    {
        rulesBoardUI.GetComponent<RulesBoardUI>().SetRulesText(newText);
    }
}
