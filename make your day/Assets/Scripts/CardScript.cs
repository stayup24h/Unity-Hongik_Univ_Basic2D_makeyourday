using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardScript : MonoBehaviour
    , IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{
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
                subType = 2;
                tirednessPoint = 5;
                takentime = 4;
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
            GameManager.tiredness += tirednessPoint;
            GameManager.happiness += 1;
            //turn 함수
        }
        else
        {
            GameManager.tiredness += tirednessPoint;
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