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

    public void Reset()
    {
        usedCard = 0;
    }

    public void UseCard()
    {
        usedCard += 1;
    }

    public void Check()
    {
        if (usedCard < 5)
        {
            GameManager.Instance.GameOver();
        }
    }
}