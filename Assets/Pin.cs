using UnityEngine;

public class Pin : MonoBehaviour
{
    public Score score;
    public float delTime = 1.5f;

    public bool isDown { get; private set; }
    Renderer rend;

    void Start() { rend = GetComponent<Renderer>(); }

    void Update()
    {
        if (!isDown && Vector3.Angle(transform.up, Vector3.up) > 45f)
        {
            isDown = true;
            rend.material.color = Color.green;
            if (score != null) score.PinFall();
            Invoke(nameof(Hide), delTime);
        }
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }
}