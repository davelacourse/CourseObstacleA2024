using UnityEngine;
using UnityEngine.SceneManagement;

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
    public int Pointage => _pointage;

    private float _tempsFinal;
    public float TempsFinal => _tempsFinal;

    private float _tempsDepart;
    public float TempsDepart => _tempsDepart;

    private UIManagerJeu _uiManagerJeu;

    void Start()
    {
        _uiManagerJeu = FindObjectOfType<UIManagerJeu>();
        _pointage = 0;
        _tempsDepart = Time.time;
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetTempsFinal()
    {
        _tempsFinal = Time.time - _tempsDepart;
    }

    public void AugmenterPointage()
    {
        _pointage++;
        _uiManagerJeu.ChangerPointage();
    }
}
