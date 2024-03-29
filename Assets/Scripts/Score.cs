using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance {set; get;}
    TextMeshProUGUI text = default;
    public int score = 0;

    private void Awake()
    {
        Instance = this;
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.SetText($"SCORE: {score}");
    }
}
