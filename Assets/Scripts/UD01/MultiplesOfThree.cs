using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Variables
    public int Number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        ShowMultiplesOfThree();

    }

    private void ShowMultiplesOfThree()
    {

        int i = 0;

        while (i <= 100)
        {

            if (i % 3 == 0)
            {

                Debug.Log(i);

            }

            i++;

        }

    }

}
