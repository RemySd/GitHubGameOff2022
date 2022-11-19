using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RulesBoardUI : MonoBehaviour
{
    [SerializeField] private Text rulesText;
    [SerializeField] public TextAsset jsonFile;

    private void Start()
    {
        JObject jObject = JObject.Parse(jsonFile.ToString());

        rulesText.text = jObject.SelectToken(SceneManager.GetActiveScene().name).ToString();
    }

    public void SetRulesText(string newText)
    {
        rulesText.text = newText;
    }
}
