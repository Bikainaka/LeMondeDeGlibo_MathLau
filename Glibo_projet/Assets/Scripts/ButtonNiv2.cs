using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNiv2 : MonoBehaviour
{
    public string niv2 = "Niveau2"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(niv2);
    }
}