using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    private int maxHealth = 15;

    private void Update()
    {
        float fillAmount = (float)GameManager.Instance.health / maxHealth;
        healthBar.fillAmount = fillAmount;
    }
}