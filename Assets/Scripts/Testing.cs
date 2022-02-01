using UnityEngine;
using UnityEngine.SceneManagement;

public class Testing : MonoBehaviour
{
    [SerializeField]
    GameObject PauseMenuUI;
    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseMenu() {
        Time.timeScale = 0;
        PauseMenuUI.SetActive(true);
    }

    public void Resume() {
        Time.timeScale = 1;
        PauseMenuUI.SetActive(false);
    }

    public void MainMenu() {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void StartEndless()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Testing");
    }
}
