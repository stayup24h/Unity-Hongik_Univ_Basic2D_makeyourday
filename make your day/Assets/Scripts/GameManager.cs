using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static int[] turn = new int[24];
    private int week;
    public static int tiredness;
    public static int[] card = new int[5];
    private Subject[] sub = new Subject[4];

    public void Start()
    {
        //과목 객체 arr 선언
        sub[0] = new Subject("대학수학(1)", "blue");
        sub[1] = new Subject("C 프로그래밍", "green");
        sub[2] = new Subject("기초평면(1)", "yellow");
        sub[3] = new Subject("기초입체(1)", "red");

        newDayStart();
    }
    public void newDayStart()
    {
        for (int i = 0; i < 4; i++)
        {
            card[i] = Random.Range(1, 4);
        }
        card[4] = 0;

        for (int i = 0; i < 5; i++) 
        {
            Debug.Log(card[i]);
        }
    }

    public void WeekEnd()
    {
        for(int i = 0; i < 4; i++)
        {
            sub[i].Check();
            sub[i].Reset();
        }
        if ( week == 7)
        {
            week = 1;
        }
        else
        {
            week += 1;
        }
    }

    public void GameOver()
    {

    }
}