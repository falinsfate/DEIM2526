using UnityEngine;

public class Odd : MonoBehaviour
{

    // Variables
    public int Number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetNumber0To100While();

    }

    private void GetNumber0To100While()
    {

        int i = 0;
        
        while (i <= 100)
        {

            if (i % 2 != 0)
            {

                Debug.Log(i);

            }

            i++;

        }

    }

}

