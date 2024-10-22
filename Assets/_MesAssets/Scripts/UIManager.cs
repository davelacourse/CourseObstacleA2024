using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Scène Début")]
    [SerializeField] private GameObject _panneauBoutons = default(GameObject);
    [SerializeField] private GameObject _panneauInstructions = default(GameObject);

    [Header("Scène fin")]
    [SerializeField] private TMP_Text _txtTempsFinal = default(TMP_Text);
    [SerializeField] private TMP_Text _txtAccrochages = default(TMP_Text);
    [SerializeField] private TMP_Text _txtPointageFinal = default(TMP_Text);

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            _txtTempsFinal.text = "Temps final : " + GameManager.Instance.TempsFinal.ToString("f2") + " secondes";
            _txtAccrochages.text = "Accrochages totaux : " + GameManager.Instance.Pointage;
            float total = GameManager.Instance.TempsFinal + GameManager.Instance.Pointage;
            _txtPointageFinal.text = "Pointage Final : " + total.ToString("f2") + " secondes";
        }
    }

    public void OnDemarrerClick()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index+1);
    }

    public void OnInstructionsClick()
    {
        _panneauBoutons.SetActive(false);
        _panneauInstructions.SetActive(true);
    }

    public void OnFermerClick()
    {
        _panneauBoutons.SetActive(true);
        _panneauInstructions.SetActive(false);
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
}
