using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{

    //Variables
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsDescendingNumber();
        
    }

    private void IsDescendingNumber()
    {

        if (NumberOne >= NumberTwo && NumberTwo >= NumberThree)
        {

            Debug.Log("El orden descendente de los n�meros es: " + NumberOne + "\t" + NumberTwo + "\t" + NumberThree);

        }
        else if (NumberOne >= NumberThree && NumberThree >= NumberTwo)
        {

            Debug.Log("El orden descendente de los n�meros es: " + NumberOne + "\t" + NumberThree + "\t" + NumberTwo);

        }
        else if (NumberTwo >= NumberOne && NumberOne >= NumberThree)
        {

            Debug.Log("El orden descendente de los n�meros es: " + NumberTwo + "\t" + NumberOne + "\t" + NumberThree);

        }
        else if (NumberTwo >= NumberThree && NumberThree >= NumberOne)
        {

            Debug.Log("El orden descendente de los n�meros es: " + NumberTwo + "\t" + NumberThree + "\t" + NumberOne);

        }
        else if (NumberThree >= NumberOne && NumberOne >= NumberTwo)
        {

            Debug.Log("El orden descendente de los n�meros es: " + NumberThree + "\t" + NumberOne + "\t" + NumberTwo);

        }
        else if (NumberThree >= NumberTwo && NumberTwo >= NumberOne)
        {

            Debug.Log("El orden descendente de los n�meros es: " + NumberThree + "\t" + NumberTwo + "\t" + NumberOne);

        }
        else
        {

            Debug.Log("Algunos n�meros son iguales.");

        }

    }

}
