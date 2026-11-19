using UnityEngine;
using UnityEngine.SceneManagement;

public class EchecNiv2 : MonoBehaviour
{
    public string echec = "EchecNiv2"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(echec);
    }
}