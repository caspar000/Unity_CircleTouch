using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float scale = 0.005f, radius = 1f;

    [SerializeField]
    private int steps = 150;

    [SerializeField]
    GameObject circleRenderer;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += new Vector3(scale, scale, 0f) * Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            float currentRadius = gameObject.transform.localScale.x/2f;
            if ((currentRadius > radius - 0.13f) && (currentRadius < radius + 0.13f))
            {
                AudioManager.instance.Play("click");
                Score.Instance.score += 1;
                scale = -scale;
                if (scale < 0){
                    radius = Random.Range(0.3f, currentRadius);
                    circleRenderer.GetComponent<CircleRenderer>().DrawCircle(steps, radius);
                    // Debug.Log($"Circle Radius is {currentRadius} and next objective radius is {radius}");
                }
                if (scale > 0){
                    radius = Random.Range(currentRadius, 2f);
                    circleRenderer.GetComponent<CircleRenderer>().DrawCircle(steps, radius);
                    // Debug.Log($"Circle Radius is {currentRadius} and next objective radius is {radius}");
                }
            }
            else {
                AudioManager.instance.Play("death");
                Destroy(gameObject);
            }
        }
    }
}
