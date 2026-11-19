using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoireNiv2 : MonoBehaviour
{
    public string succes = "SuccesNiv2"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(succes);
    }
}