using UnityEngine;

public class Change : MonoBehaviour
{
    // Zona de variables globales
    [SerializeField]
    private int[] _numbers = new int[5] { 1, 1, 1, 1, 1 };


    // Start se ejecuta una sola vez al iniciar
    void Start()
    {

        Operations();

    }


    private void Operations()
    {

        // Imprimir la cantidad de elementos del array
        Debug.Log("Número de elementos del array: " + _numbers.Length);

        // Cambiar el primer y último valor a 42
        _numbers[0] = 42;
        _numbers[_numbers.Length - 1] = 42;

        // Imprimir el valor de cada posición
        for (int i = 0; i < _numbers.Length; i++)
        {

            Debug.Log("Valor de la casilla " + (i + 1) + ": " + _numbers[i]);

        }

    }

}
