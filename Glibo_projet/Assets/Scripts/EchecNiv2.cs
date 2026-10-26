using UnityEngine;
using UnityEngine.SceneManagement;

public class EchecNiv1 : MonoBehaviour
{
    public string echec = "EchecNiv1"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(echec);
    }
}