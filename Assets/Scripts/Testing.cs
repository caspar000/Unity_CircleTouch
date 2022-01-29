using UnityEngine;
using UnityEngine.SceneManagement;

public class Testing : MonoBehaviour
{
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
