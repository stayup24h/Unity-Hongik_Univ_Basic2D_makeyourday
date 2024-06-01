using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    TextMeshProUGUI happinessText;
    TextMeshProUGUI tirednessText;
    public GameObject happinessIndicator;
    public GameObject tirednessIndicator;

    void Start()
    {
        GameManager.tiredness = 0;
        GameManager.happiness = 0;

        happinessText  = happinessIndicator.GetComponent<TextMeshProUGUI>();
        tirednessText = tirednessIndicator.GetComponent<TextMeshProUGUI>();
    }

    void Update() // UI update
    {
        happinessText.text = "Happiness: " + GameManager.happiness.ToString();
        tirednessText.text = "Tiredness: " + GameManager.tiredness.ToString();
    }
}
