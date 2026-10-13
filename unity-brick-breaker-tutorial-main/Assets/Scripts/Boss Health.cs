using UnityEngine;  
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public Image bossHealthBar;
    private int maxBossHealth = 15;

    private void Update()
    {
        float fillAmount = (float)GameManager.Instance.bossHealth / maxBossHealth;
        bossHealthBar.fillAmount = fillAmount;
    }
}