using UnityEngine;

public class Increment : MonoBehaviour
{
    // Zona de variables globales

    // Número que introduce el usuario
    [SerializeField]
    private int _number;

    // Booleano para activar la operación
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

    // Método que recibe un número por parámetro y lo incrementa
    private void IncreaseByOne(int number)
    {
        number = number + 1;

        Debug.Log("El número incrementado es: " + number);

    }

}
