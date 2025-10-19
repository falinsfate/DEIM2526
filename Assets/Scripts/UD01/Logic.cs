using UnityEngine;

public class Logic : MonoBehaviour
{
    // Zona de variables globales
    [SerializeField]
    private bool[] _logicValues = new bool[3] { false, false, false };


    // Start se ejecuta una sola vez al iniciar
    void Start()
    {

        Operations();

    }


    private void Operations()
    {

        // Marcar como verdadero el primer valor del array
        _logicValues[0] = true;

        // Mostrar los valores de cada posición
        Debug.Log("Valor de la primera casilla: " + _logicValues[0]);
        Debug.Log("Valor de la segunda casilla: " + _logicValues[1]);
        Debug.Log("Valor de la tercera casilla: " + _logicValues[2]);

    }

}
