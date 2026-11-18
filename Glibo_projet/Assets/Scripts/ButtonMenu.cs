using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public string menu = "Menu"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(menu);
    }
}