using UnityEngine;
using UnityEngine.SceneManagement;

public class EchecNiv3 : MonoBehaviour
{
    public string echec = "EchecNiv3"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(echec);
    }
}