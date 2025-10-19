using UnityEngine;

public class Score : MonoBehaviour
{

    // Zona de variables globales

    // Puntuación del jugador (asignada desde el Inspector)
    [SerializeField]
    private int _score;

    // Booleano para activar la comprobación
    [SerializeField]
    private bool _checkScore;

    // Start se ejecuta una sola vez al iniciar el juego
    void Start()
    {

        Operations();

    }

    private void Operations()
    {

        if (_checkScore == true)
        {

            CheckIfReachedScore(_score);

        }

    }

    // Método propio que recibe la puntuación por parámetro
    private void CheckIfReachedScore(int score)
    {

        if (score >= 45)
        {

            Debug.Log("¡Felicidades! Has alcanzado o superado los 45 puntos.");

        }
        else
        {

            Debug.Log("Aún no has llegado a los 45 puntos. Tu puntuación actual es: " + score);

        }

    }

}
