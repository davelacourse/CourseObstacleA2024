using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UIManagerJeu : MonoBehaviour
{

    [SerializeField] private TMP_Text _txtTemps = default(TMP_Text);
    [SerializeField] private TMP_Text _txtAccrochages = default(TMP_Text);
    [SerializeField] private GameObject _panelPause = default(GameObject);

    private bool _enPause;

    private void Start()
    {
        ChangerPointage();
        _panelPause.SetActive(false);
        _enPause = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        float temps = Time.time - GameManager.Instance.TempsDepart;
        _txtTemps.text = "Temps : " + temps.ToString("f2");
        GestionPause();
    }

    private void GestionPause()
    {
        if (Input.GetButtonDown("Pause") && !_enPause)
        {
            _panelPause.SetActive(true);
            _enPause = true;
            Time.timeScale = 0;
        }
        else if(Input.GetButtonDown("Pause") && _enPause)
        {
            EnleverPause();
        }
    }

    private void EnleverPause()
    {
        _panelPause.SetActive(false);
        _enPause = false;
        EventSystem.current.SetSelectedGameObject(null);
        Time.timeScale = 1;
    }

    public void ChangerPointage()
    {
        _txtAccrochages.text = "Accrochages : " + GameManager.Instance.Pointage;
    }

    public void OnQuitterClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void OnRetourClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnReprendreClick()
    {
        EnleverPause();
    }
}
