public class Subject
{
    public string name;
    public string color;
    public int usedCard;

    public Subject(string _name, string _color)
    {
    name = _name;
    color = _color;
    usedCard = 0;
    }

    public void Reset() // 1주마다 초기화
    {
        usedCard = 0;
    }

    public void UseCard() // 카드 사용
    {
        if (usedCard < 5)
        {
            usedCard += 1;
        }
        else
        {
            usedCard = 5;
        }
    }

    public void Check() // 과제 다했는지 검사
    {
        if (usedCard < 5)
        {
            GameManager.Instance.GameOver();
        }
    }
}