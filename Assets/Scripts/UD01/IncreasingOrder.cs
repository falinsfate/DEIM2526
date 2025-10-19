using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    // Variables
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        DetectIncreasingOrder();

    }

    private void DetectIncreasingOrder()
    {

        Debug.Log("Los n�meros introducidos son: " + NumberOne + ", " + NumberTwo + ", " + NumberThree);

        if (NumberOne < NumberTwo && NumberTwo < NumberThree)
        {

            Debug.Log("Los n�meros est�n en orden creciente.");

        }
        else if (NumberOne == NumberTwo && NumberTwo == NumberThree)
        {

            Debug.Log("Los tres n�meros son iguales.");

        }
        else if ((NumberOne == NumberTwo && NumberTwo < NumberThree) || (NumberOne < NumberTwo && NumberTwo == NumberThree))
        {

            Debug.Log("Los n�meros son crecientes, pero hay algunos iguales.");

        }
        else
        {

            Debug.Log("Los n�meros no est�n en orden creciente.");

        }
    }

}