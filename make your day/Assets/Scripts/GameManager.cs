using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameObject CardManager;
    public static int[] turn = new int[24]; // 0 = 공강, 1 = 기초평면(1), 2 = 대학수학(1), 3 = 기초입체(1), 4 = c-프로그래밍, 5 = 교양
    private int week;
    public static int tiredness;
    public static int happiness;
    public static int[] card = new int[5];
    public Subject[] sub = new Subject[4];
    public static int happyScore; // 점수

    public void Start()
    {
        //과목 객체 arr 선언
        sub[0] = new Subject("대학수학(1)", "blue");
        sub[1] = new Subject("C 프로그래밍", "green");
        sub[2] = new Subject("기초평면(1)", "yellow");
        sub[3] = new Subject("기초입체(1)", "red");

        //변수 초기화
        week = 0;

        newDayStart();
    }
    public void newDayStart()
    {
        for (int i = 0; i < 4; i++) //카드 뽑기
        {
            card[i] = Random.Range(1, 15);
        }
        card[4] = 0;

        for (int i = 0; i < 5; i++) //카드 생성
        {
            Debug.Log(card[i]);
            CardManager.GetComponent<CardManager>().showCard(i, card[i]);
        }
        for (int i = 0; i < 24; i++)
        {
            turn[i] = 0;
        }
        switch(week)// 요일별 일정 설정
        {
            case 0:
                turn[10] = 1;
                turn[11] = 1;
                turn[12] = 1;
                turn[15] = 5;
                turn[16] = 5;
                break;
            case 1:
                turn[10] = 5;
                turn[11] = 5;
                turn[12] = 5;
                turn[15] = 2;
                turn[16] = 2;
                break;
            case 2:
                turn[10] = 3;
                turn[11] = 3;
                turn[12] = 3;
                turn[15] = 2;
                turn[16] = 2;
                break;
            case 3:
                turn[11] = 2;
                turn[13] = 4;
                turn[14] = 4;
                turn[15] = 4;
                break;
        }
    }

    public void WeekEnd() // 한주 과제 달성 경과 확인
    {
        for(int i = 0; i < 4; i++)
        {
            sub[i].Check();
            sub[i].Reset();
        }
        
        if ( week == 6)
        {
            week = 0;
        }
        else
        {
            week += 1;
        }
    }

    public void GameOver() // 게임오버
    {

    }
}