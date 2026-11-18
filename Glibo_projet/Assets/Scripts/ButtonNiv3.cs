using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNiv3 : MonoBehaviour
{
    public string niv3 = "Niveau3"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(niv3);
    }
}