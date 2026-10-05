using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNiv1 : MonoBehaviour
{
    public string niv1 = "Niveau1"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(niv1);
    }
}