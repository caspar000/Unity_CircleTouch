using UnityEngine;

public class CircleRenderer : MonoBehaviour
{
    public LineRenderer circleRenderer;

    [SerializeField]
    private int steps=100;
    
    [SerializeField]
    private float radius=1f, offsetX=0f, offsetY=0f;

    void Start()
    {
        DrawCircle(steps,radius);
    }

    public void DrawCircle(int steps, float radius)
    {
        circleRenderer.positionCount = steps;

        for (int currentStep = 0; currentStep<steps; currentStep++)
        {
            float circumferenceProgress = (float)currentStep/steps;

            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);

            float x = xScaled * radius;
            float y = yScaled * radius;

            Vector3 currentPosition = new Vector3(x + offsetX,y + offsetY,0);

            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }
}
