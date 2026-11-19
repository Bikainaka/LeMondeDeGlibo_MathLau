using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoireNiv3 : MonoBehaviour
{
    public string succes = "SuccesNiv3"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(succes);
    }
}