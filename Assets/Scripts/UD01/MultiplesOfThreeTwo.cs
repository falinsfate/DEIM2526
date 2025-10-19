using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        ShowMultiplesOfTwoAndThree();

    }

    private void ShowMultiplesOfTwoAndThree()
    {

        int i = 0;

        while (i <= 100)
        {

            // Mostrar los múltiplos de 2 o de 3
            if (i % 2 == 0 || i % 3 == 0)
            {

                Debug.Log(i);

            }

            i++;

        }

    }

}
