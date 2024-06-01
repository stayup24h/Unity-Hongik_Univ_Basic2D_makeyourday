using UnityEngine;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{
    private int cardType;
    public Image img;
    public Sprite card0;
    public Sprite card1;
    public Sprite card2;
    public Sprite card3;
    public Sprite card4;
    public Sprite card5;
    public Sprite card6;
    public Sprite card7;
    public Sprite card8;
    public Sprite card9;
    public Sprite card10;
    public Sprite card11;
    public Sprite card12;
    public Sprite card13;
    public Sprite card14;
    public Sprite card15;
    void Start()
    {
        img = GetComponent<Image>();
    }

    public void ShowCard(int _cardType) // 카드 type에 맞는 이미지로 변경
    {
        cardType = _cardType;

        switch(_cardType)
        {
            case 0:
                img.sprite = card0;
                break;
            case 1:
                img.sprite = card1;
                break;
            case 2:
                img.sprite = card2;
                break;
            case 3:
                img.sprite = card3;
                break;
            case 4:
                img.sprite = card4;
                break;
            case 5:
                img.sprite = card5;
                break;
            case 6:
                img.sprite = card6;
                break;
            case 7:
                img.sprite = card7;
                break;
            case 8:
                img.sprite = card8;
                break;
            case 9:
                img.sprite = card9;
                break;
            case 10:
                img.sprite = card10;
                break;
            case 11:
                img.sprite = card11;
                break;
            case 12:
                img.sprite = card12;
                break;
            case 13:
                img.sprite = card13;
                break;
            case 14:
                img.sprite = card14;
                break;
            case 15:
                img.sprite = card15;
                break;
            default:
                img.sprite = card0;
                cardType = 0;
                break;
        }
    }
}