using UnityEngine;

public class Week : MonoBehaviour
{

    //Variables
    public int DayNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsDayWeek();

    }

    private void IsDayWeek()
    {

        switch(DayNumber)
        {

            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Mi�rcoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("S�bado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
            default:
                Debug.Log("El n�mero introducido no se corresponde con ning�n d�a de la semana.");
                break;
        }

    }

}
