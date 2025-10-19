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

        Debug.Log("Los números introducidos son: " + NumberOne + ", " + NumberTwo + ", " + NumberThree);

        if (NumberOne < NumberTwo && NumberTwo < NumberThree)
        {

            Debug.Log("Los números están en orden creciente.");

        }
        else if (NumberOne == NumberTwo && NumberTwo == NumberThree)
        {

            Debug.Log("Los tres números son iguales.");

        }
        else if ((NumberOne == NumberTwo && NumberTwo < NumberThree) || (NumberOne < NumberTwo && NumberTwo == NumberThree))
        {

            Debug.Log("Los números son crecientes, pero hay algunos iguales.");

        }
        else
        {

            Debug.Log("Los números no están en orden creciente.");

        }
    }

}