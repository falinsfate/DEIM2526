using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    // Zona de variables globales
    [SerializeField]
    private string[] _predictions = new string[5]
    {

        "Tendr�s un gran d�a lleno de sorpresas.",
        "Conocer�s a alguien interesante muy pronto.",
        "Aprender�s algo nuevo que te har� feliz.",
        "Un desaf�o se convertir� en una oportunidad.",
        "Tu creatividad alcanzar� un nuevo nivel."

    };


    // Start se ejecuta una sola vez al iniciar
    void Start()
    {

        ShowRandomPrediction();

    }


    private void ShowRandomPrediction()
    {

        // Elegir un �ndice aleatorio entre 0 y 4
        int randomIndex = Random.Range(0, 5);

        // Imprimir la predicci�n aleatoria en consola
        Debug.Log("Predicci�n aleatoria: " + _predictions[randomIndex]);

    }

}