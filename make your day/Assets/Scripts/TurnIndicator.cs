using UnityEngine;
using System.Collections;

public class TurnIndicator : MonoBehaviour
{
    public GameObject TurnIndicatorPrefab;
    public Transform turnInd;
    GameObject[] turnObj = new GameObject[24];

    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            turnObj[i] = Instantiate(TurnIndicatorPrefab, turnInd);
            turnObj[i].transform.position = new Vector3(-137f+15f*i+341.5f, 170f+192.2f, 0);
        }
    }
}