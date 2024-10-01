using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Déclaration singleton
    //-------------------------------------------------
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    //-------------------------------------------------

    // Attributs 
    private int _pointage;
    
    void Start()
    {
        _pointage = 0;
    }

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochages : " + _pointage);
    }

    public void FinPartie()
    {
        Debug.Log("Le nombre total de collision est : " + _pointage);
    }
}
