using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    TextMeshProUGUI happinessText;
    TextMeshProUGUI tirednessText;
    TextMeshProUGUI subjectsText;
    public GameObject happinessIndicator;
    public GameObject tirednessIndicator;
    public GameObject subjectsIndicator;

    void Awake()
    {
        GameManager.Instance.GameStart(); //게임 초기화

        happinessText  = happinessIndicator.GetComponent<TextMeshProUGUI>();
        tirednessText = tirednessIndicator.GetComponent<TextMeshProUGUI>();
        subjectsText = subjectsIndicator.GetComponent<TextMeshProUGUI>();
    }

    void Update() // UI update
    {
        happinessText.text = "Happiness: " + GameManager.happiness.ToString();
        tirednessText.text = "Tiredness: " + GameManager.tiredness.ToString();
        subjectsText.text = "math: " + GameManager.Instance.sub[0].usedCard.ToString()
        +"/5\nC-Programming: "+GameManager.Instance.sub[1].usedCard.ToString()
        +"/5\nBasic 2D: "+GameManager.Instance.sub[2].usedCard.ToString()
        +"/5\nBasic 3D: "+GameManager.Instance.sub[3].usedCard.ToString()+"/5";
    }
}