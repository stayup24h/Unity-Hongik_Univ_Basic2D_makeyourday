using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static int turn;
    Subject sub1 = new Subject("대학수학(1)", "blue");
    Subject sub2 = new Subject("C 프로그래밍", "green");
    Subject sub3 = new Subject("기초평면(1)", "yellow");
    Subject sub4 = new Subject("기초입체(1)", "red");


    public void WeekEnd()
    {
        sub1.Check();
        sub2.Check();
        sub3.Check();
        sub4.Check();
        sub1.Reset();
        sub2.Reset();
        sub3.Reset();
        sub4.Reset();
    }

    public void GameOver()
    {

    }
}
