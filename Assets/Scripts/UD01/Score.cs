using UnityEngine;

public class Score : MonoBehaviour
{

    // Zona de variables globales

    // Puntuaci�n del jugador (asignada desde el Inspector)
    [SerializeField]
    private int _score;

    // Booleano para activar la comprobaci�n
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

    // M�todo propio que recibe la puntuaci�n por par�metro
    private void CheckIfReachedScore(int score)
    {

        if (score >= 45)
        {

            Debug.Log("�Felicidades! Has alcanzado o superado los 45 puntos.");

        }
        else
        {

            Debug.Log("A�n no has llegado a los 45 puntos. Tu puntuaci�n actual es: " + score);

        }

    }

}
