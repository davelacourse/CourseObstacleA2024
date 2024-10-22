using TMPro;
using UnityEngine;

public class UIManagerJeu : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTemps = default(TMP_Text);
    [SerializeField] private TMP_Text _txtAccrochages = default(TMP_Text);

    private void Start()
    {
        ChangerPointage();
    }

    private void Update()
    {
        float temps = Time.time - GameManager.Instance.TempsDepart;
        _txtTemps.text = "Temps : " + temps.ToString("f2");
    }

    public void ChangerPointage()
    {
        _txtAccrochages.text = "Accrochages : " + GameManager.Instance.Pointage;
    }
}
