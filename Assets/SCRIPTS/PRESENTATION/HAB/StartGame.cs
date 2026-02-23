using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public void StartMaingame()
    {
        SceneManager.LoadScene("Main_Game");
    }
}
