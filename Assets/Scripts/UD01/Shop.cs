using UnityEngine;

public class Shop : MonoBehaviour
{
    // Zona de variables globales

    // Unidades iniciales de productos
    [SerializeField]
    private int _broccoliUnits;
    [SerializeField]
    private int _potatoUnits;

    // Cantidades a añadir o restar (decididas por el usuario)
    [SerializeField]
    private int _broccoliChange;
    [SerializeField]
    private int _potatoChange;

    // Booleans para decidir acción por producto
    [SerializeField]
    private bool _isAddBroccoli;
    [SerializeField]
    private bool _isRemoveBroccoli;
    [SerializeField]
    private bool _isAddPotato;
    [SerializeField]
    private bool _isRemovePotato;


    // Start se ejecuta una sola vez al iniciar
    void Start()
    {

        Operations();

    }


    private void Operations()
    {

        // Brécol
        if (_isAddBroccoli == true)
        {

            AddBroccoli(_broccoliUnits, _broccoliChange);

        }

        if (_isRemoveBroccoli == true)
        {

            RemoveBroccoli(_broccoliUnits, _broccoliChange);

        }

        // Patata
        if (_isAddPotato == true)
        {

            AddPotato(_potatoUnits, _potatoChange);

        }

        if (_isRemovePotato == true)
        {

            RemovePotato(_potatoUnits, _potatoChange);

        }

    }


    private void AddBroccoli(int broccoliUnits, int broccoliChange)
    {

        broccoliUnits = broccoliUnits + broccoliChange;

        Debug.Log("Se han añadido " + broccoliChange + " unidades de brécol.");
        Debug.Log("Total de brécol: " + broccoliUnits);

    }


    private void RemoveBroccoli(int broccoliUnits, int broccoliChange)
    {

        broccoliUnits = broccoliUnits - broccoliChange;

        if (broccoliUnits < 0)
        {

            broccoliUnits = 0;

        }

        Debug.Log("Se han restado " + broccoliChange + " unidades de brécol.");
        Debug.Log("Total de brécol: " + broccoliUnits);

    }


    private void AddPotato(int potatoUnits, int potatoChange)
    {

        potatoUnits = potatoUnits + potatoChange;

        Debug.Log("Se han añadido " + potatoChange + " unidades de patata.");
        Debug.Log("Total de patata: " + potatoUnits);

    }


    private void RemovePotato(int potatoUnits, int potatoChange)
    {

        potatoUnits = potatoUnits - potatoChange;

        if (potatoUnits < 0)
        {

            potatoUnits = 0;

        }

        Debug.Log("Se han restado " + potatoChange + " unidades de patata.");
        Debug.Log("Total de patata: " + potatoUnits);

    }

}
