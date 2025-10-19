using UnityEngine;

public class Increment : MonoBehaviour
{
    // Zona de variables globales

    // N�mero que introduce el usuario
    [SerializeField]
    private int _number;

    // Booleano para activar la operaci�n
    [SerializeField]
    private bool _isIncrement;

    // Start se ejecuta una sola vez al iniciar
    void Start()
    {

        Operations();

    }

    private void Operations()
    {

        if (_isIncrement == true)
        {

            IncreaseByOne(_number);

        }

    }

    // M�todo que recibe un n�mero por par�metro y lo incrementa
    private void IncreaseByOne(int number)
    {
        number = number + 1;

        Debug.Log("El n�mero incrementado es: " + number);

    }

}
