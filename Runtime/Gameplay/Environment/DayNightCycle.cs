using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Settings")]
    [Tooltip("Duration in seconds for one full day cycle")]
    public float dayDurationInSeconds = 120f;

    [Tooltip("Axis used for rotation (usually X for sunrise to sunset)")]
    public Vector3 rotationAxis = Vector3.right;


    [Header("Light Settings")]
    public Light directionalLight;
    public AnimationCurve lightIntensityCurve;

    private float timeOfDay = 0f;
    
    private float rotationSpeed; // Degrees per second

    private void Start()
    {
        if (dayDurationInSeconds <= 0)
        {
            Debug.LogWarning("dayDurationInSeconds must be greater than 0");
            dayDurationInSeconds = 60f;
        }

        // 360 degrees per full day
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    // private void Update()
    // {
    //     // Rotate the light every frame
    //     transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    // }


    private void Update()
    {
        // Normalize time (0 → 1 over a full day)
        timeOfDay += Time.deltaTime / dayDurationInSeconds;
        timeOfDay %= 1f;

        // Convert normalized time to angle (0 → 360 degrees)
        float angle = timeOfDay * 360f;
        transform.rotation = Quaternion.Euler(angle, 0f, 0f);

        // Adjust light intensity based on time of day
        if (directionalLight != null && lightIntensityCurve != null)
        {
            directionalLight.intensity = lightIntensityCurve.Evaluate(timeOfDay);
        }
    }
}
