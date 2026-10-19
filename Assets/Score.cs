using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int totalPins = 10;
    int fallen = 0;
    public ParticleSystem strikeEffect;

    void Start() { UpdateText(); }

    public void PinFall()
    {
        fallen++;
        UpdateText();
    }

    void UpdateText()
    {
        scoreText.text = "Popice cazute:  " + fallen + " / " + totalPins;
        if (fallen >= totalPins)
        {
            scoreText.text += "\nSTRIKE!";
            if (strikeEffect != null) strikeEffect.Play();
        }
    }
}
