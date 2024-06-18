using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Image healthBarImage;
    [SerializeField] FloatVariable playerHealth;
    [SerializeField] FloatVariable playerMaxHealth;

    void Update()
    {
        //TODO: muuta vain, kun pelaaja ottaa damagea tai ker‰‰ healthia tms.
        healthBarImage.fillAmount = playerHealth.Value / playerMaxHealth.Value;
    }
}
