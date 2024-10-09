using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnDemarrerClick()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index+1);
    }

    public void OnInstaructionsClick()
    {

    }

    public void OnQuitterClick()
    {

    }
}
