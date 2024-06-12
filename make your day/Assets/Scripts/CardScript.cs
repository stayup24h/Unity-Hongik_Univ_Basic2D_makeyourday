using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardScript : MonoBehaviour
    , IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{
    private int cardNumber;
    private int cardType;
    private int subType; // 0: 대학수학(1), 1: c-프로그래밍, 2: 기초평면(1), 3: 기초입체(1), 4: 여가, 5: 휴식
    private int tirednessPoint;
    private int takentime;
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

    public void ShowCard(int _cardType, int _cardNumber) // 카드 type에 맞는 이미지로 변경
    {
        cardType = _cardType;
        cardNumber = _cardNumber;

        switch(_cardType)
        {
            case 0:
                subType = 5;
                img.sprite = card0;
                break;
            case 1:
                subType = 0;
                tirednessPoint  = 2;
                takentime  = 1;
                img.sprite = card1;
                break;
            case 2:
                subType = 0;
                tirednessPoint  = 3;
                takentime  = 2;
                img.sprite = card2;
                break;
            case 3:
            subType = 0;
                tirednessPoint  = 5;
                takentime = 3;
                img.sprite = card3;
                break;
            case 4:
                subType = 1;
                tirednessPoint  = 1;
                takentime = 1;
                img.sprite = card4;
                break;
            case 5:
                subType = 1;
                tirednessPoint = 2;
                takentime  = 1;
                img.sprite = card5;
                break;
            case 6:
                subType = 1;
                tirednessPoint  = 3;
                takentime  = 2;
                img.sprite = card6;
                break;
            case 7:
                subType = 2;
                tirednessPoint  = 3;
                takentime = 2;
                img.sprite = card7;
                break;
            case 8:
                subType = 2;
                tirednessPoint = 5;
                takentime = 4;
                img.sprite = card8;
                break;
            case 9:
                subType = 2;
                tirednessPoint  = 7;
                takentime  = 6;
                img.sprite = card9;
                break;
            case 10:
                subType = 3;
                tirednessPoint  = 5;
                takentime  = 3;
                img.sprite = card10;
                break;
            case 11:
                subType = 3;
                tirednessPoint  = 9;
                takentime  = 5;
                img.sprite = card11;
                break;
            case 12:
                subType = 3;
                tirednessPoint  = 13;
                takentime  = 7;
                img.sprite = card12;
                break;
            case 13:
                subType = 4;
                img.sprite = card13;
                break;
            case 14:
                subType = 4;
                img.sprite = card14;
                break;
            case 15:
                subType = 4;
                img.sprite = card15;
                break;
            default:
                img.sprite = card0;
                cardType = 0;
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(cardType.ToString() + " enter");
        StartCoroutine(Emphasis());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(cardType.ToString() + " exit");
        StopCoroutine(Emphasis());
        this.transform.localScale = new Vector3(1,1,1);

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(cardType.ToString() + " click");
        if (subType == 5)
        {
            
        }
        else if(subType == 4)
        {
            GameManager.tiredness += 1;
            GameManager.happiness += 1;
            GameManager.Instance.UseCard(cardNumber);
            //turn 함수
            Destroy(this.gameObject);
        }
        else
        {
            GameManager.Instance.sub[subType].UseCard();
            GameManager.tiredness += tirednessPoint;
            GameManager.Instance.UseCard(cardNumber);
            //turn 함수
        }
    }

    private IEnumerator Emphasis()
    {
        float increase = 0.04f;

        while (this.GetComponent<Transform>().localScale.x <= 1.2f)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x + increase
                                                            , this.transform.localScale.y + increase
                                                            , this.transform.localScale.z);
            yield return new WaitForSeconds(0.01f); //크기가 바뀌는 속도
        }
    }
}