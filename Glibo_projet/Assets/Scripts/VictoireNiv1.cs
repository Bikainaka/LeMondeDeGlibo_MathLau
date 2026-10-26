using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoireNiv1 : MonoBehaviour
{
    public string succes = "SuccesNiv1"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(succes);
    }
}