using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform cardH;
    public GameObject[] cardObj = new GameObject[5];

    public void showCard(int _cardNumber)
    {
        cardObj[_cardNumber] = Instantiate(cardPrefab, cardH);
    }
}
