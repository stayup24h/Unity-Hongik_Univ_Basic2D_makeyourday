using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}
