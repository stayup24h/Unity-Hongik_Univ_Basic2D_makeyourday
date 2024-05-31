using UnityEngine;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{
    private int cardIndex;
    public Image img;
    public Sprite card1;
    void Start()
    {
        cardIndex = GameManager.cardIndex;
        img = GetComponent<Image>();
    }

    void Update()
    {
        img.sprite = card1;
    }
}
