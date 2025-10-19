using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    // Zona de variables globales
    [SerializeField]
    private string[] _predictions = new string[5]
    {

        "Tendrás un gran día lleno de sorpresas.",
        "Conocerás a alguien interesante muy pronto.",
        "Aprenderás algo nuevo que te hará feliz.",
        "Un desafío se convertirá en una oportunidad.",
        "Tu creatividad alcanzará un nuevo nivel."

    };


    // Start se ejecuta una sola vez al iniciar
    void Start()
    {

        ShowRandomPrediction();

    }


    private void ShowRandomPrediction()
    {

        // Elegir un índice aleatorio entre 0 y 4
        int randomIndex = Random.Range(0, 5);

        // Imprimir la predicción aleatoria en consola
        Debug.Log("Predicción aleatoria: " + _predictions[randomIndex]);

    }

}