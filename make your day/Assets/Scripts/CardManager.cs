using System.Collections;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public int moveSpeed;
    public GameObject cardPrefab;
    public Transform cardMng;
    public GameObject[] cardObj = new GameObject[5];
    private Vector3[] destination = new Vector3[5];

    public void Start()
    {
        // 카드별 위치 설정
        destination[4] = new Vector3(591, 110, 0);
        destination[3] = new Vector3(466, 160, 0);
        destination[2] = new Vector3(342, 180, 0);
        destination[1] = new Vector3(216, 160, 0);
        destination[0] = new Vector3(91, 110, 0);
    }

    public void showCard(int _cardNumber, int _cardType)
    {
        if (cardObj[_cardNumber] != null)
        {
            Destroy(cardObj[_cardNumber]);
        }
        cardObj[_cardNumber] = Instantiate(cardPrefab, cardMng); //카드 prefab생성
        cardObj[_cardNumber].transform.position = new Vector3(-100, -100, 0); //시작위치 지정
        cardObj[_cardNumber].transform.Rotate(new Vector3(0, 0,30 - 15*(_cardNumber))); // 카드 순서별 각도 변경
        cardObj[_cardNumber].GetComponent<CardScript>().ShowCard(_cardType, _cardNumber); // 카드 type에 해당하는 이미지로 변경
        StartCoroutine(cardMove(_cardNumber)); // 카드 이동 coroutine 실행
    }

    IEnumerator cardMove(int _cardNumber)
    {
        yield return new WaitForSeconds(0.1f);
        while(true) // 카드 순서별 위치로 이동
        {
            cardObj[_cardNumber].transform.position = Vector3.MoveTowards(cardObj[_cardNumber].transform.position, destination[_cardNumber], moveSpeed);
            yield return null; 
        }
    }
}