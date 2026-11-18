using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCredit : MonoBehaviour
{
    public string cred = "credit"; 

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(cred);
    }
}