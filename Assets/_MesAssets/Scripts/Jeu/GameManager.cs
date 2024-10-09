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
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
    //-------------------------------------------------

    // Attributs 
    private int _pointage;
    private int _accrochagesNiveau1;
    private float _tempsNiveau1;
    
    void Start()
    {
        _pointage = 0;
    }

    public void FinNiveau1()
    {
        _accrochagesNiveau1 = _pointage;
        _tempsNiveau1 = Time.time;
    }

    public void AugmenterPointage()
    {
        _pointage++;
    }

    public void FinPartie()
    {
        Debug.Log("Le nombre total de collision niveau 1 est : " + _accrochagesNiveau1);
        Debug.Log("Le temps total pour le niveau 1 est de : " + _tempsNiveau1.ToString("f2"));
        Debug.Log("*********************************************************************");
        Debug.Log("Le nombre total de collision niveau 2 est : " + (_pointage - _accrochagesNiveau1));
        Debug.Log("Le temps total pour le niveau 2 est de : " + (Time.time - _tempsNiveau1).ToString("f2"));
        Debug.Log("*********************************************************************");
        Debug.Log("Le nombre total de collision est : " + _pointage);
        Debug.Log("Le temps total pour les niveaux est de : " + Time.time.ToString("f2"));
        Debug.Log("Pointage final est : " + (Time.time +_pointage).ToString("f2"));
    }
}
