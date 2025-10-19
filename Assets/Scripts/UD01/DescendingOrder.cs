using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    // Variables
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        DetectDescendingOrder();

    }

    private void DetectDescendingOrder()
    {

        Debug.Log("Los n�meros introducidos son: " + NumberOne + ", " + NumberTwo + ", " + NumberThree);

        if (NumberOne > NumberTwo && NumberTwo > NumberThree)
        {

            Debug.Log("Los n�meros est�n en orden decreciente.");

        }
        else if (NumberOne == NumberTwo && NumberTwo == NumberThree)
        {

            Debug.Log("Los tres n�meros son iguales.");

        }
        else if ((NumberOne == NumberTwo && NumberTwo > NumberThree) || (NumberOne > NumberTwo && NumberTwo == NumberThree))
        {

            Debug.Log("Los n�meros son decrecientes, pero hay algunos iguales.");

        }
        else
        {

            Debug.Log("Los n�meros no est�n en orden decreciente.");

        }
    }

}
