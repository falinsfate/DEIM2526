using UnityEngine;

public class Substraction : MonoBehaviour
{
    // Variable
    public int Number;

    void Start()
    {

        ShowCountdown();

    }

    private void ShowCountdown()
    {

        int i = Number;

        while (i >= 1)
        {

            Debug.Log(i);
            i--;

        }

    }

}
