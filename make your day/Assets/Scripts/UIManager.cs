using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    TextMeshProUGUI happinessText;
    TextMeshProUGUI tirednessText;
    TextMeshProUGUI mathText;
    TextMeshProUGUI programingText;
    TextMeshProUGUI b2dText;
    TextMeshProUGUI b3dText;
    public GameObject happinessIndicator;
    public GameObject tirednessIndicator;
    public GameObject mathIndicator;
    public GameObject programingIndicator;
    public GameObject b2dIndicator;
    public GameObject b3dIndicator;

    void Awake()
    {
        GameManager.Instance.GameStart(); //게임 초기화

        happinessText  = happinessIndicator.GetComponent<TextMeshProUGUI>();
        tirednessText = tirednessIndicator.GetComponent<TextMeshProUGUI>();
        mathText = mathIndicator.GetComponent<TextMeshProUGUI>();
        programingText = programingIndicator.GetComponent<TextMeshProUGUI>();
        b2dText = b2dIndicator.GetComponent<TextMeshProUGUI>();
        b3dText = b3dIndicator.GetComponent<TextMeshProUGUI>();
    }

    void Update() // UI update
    {
        happinessText.text = GameManager.happiness.ToString();
        tirednessText.text = GameManager.tiredness.ToString();
        mathText.text = "math: " + GameManager.Instance.sub[0].usedCard.ToString()+"/5";
        programingText.text = "C-Programing: " +GameManager.Instance.sub[1].usedCard.ToString()+"/5";
        b2dText.text = "Basic 2D: "+GameManager.Instance.sub[2].usedCard.ToString()+"/5";
        b3dText.text = "Basic 3D: "+GameManager.Instance.sub[3].usedCard.ToString()+"/5";
    }
}