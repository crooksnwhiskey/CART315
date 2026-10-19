using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private const int NUM_LEVELS = 2;

    private Ball ball;
    private Paddle paddle;
    private Brick[] bricks;
    private PopupTextResurrect popupText;
    private PopupTextDeath deathText;
    private bool isDead = false;

    public int level { get; private set; } = 1;
    public int score { get; private set; } = 0;
    public int health { get; private set; } = 15;
    public int maxHealth { get; private set; } = 15;
    public int bossHealth { get; private set; } = 0;
    public int maxBossHealth { get; private set; } = 15;

    public bool hasRessurection { get; private set; } = true;

public void takeDamage(int damage) {
        health -= damage;
        
        if (health <= 0) {
            if (hasRessurection) {
                Resurrect();
            } else {
                GameOver();
            }
        }
    }
    private void Resurrect() {
        hasRessurection = false;
        health = maxHealth/2;
        if (popupText != null) {
            popupText.Show("RESURRECTED", 2f);
        }
      
    
    }
public void dealDamage(int damage) {
        bossHealth += damage;
        Debug.Log("Boss Health: " + bossHealth);
        
        if (bossHealth >= maxBossHealth) {
            bossHealth = 0;
        
            LoadLevel(level + 1);
        }
    }

    private void Awake()
    {
        if (Instance != null) {
            DestroyImmediate(gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            FindSceneReferences();
        }
    }

    private void OnDestroy()
    {
        if (Instance == this) {
            Instance = null;
        }
    }

    private void FindSceneReferences()
    {
        ball = FindFirstObjectByType<Ball>();
        paddle = FindFirstObjectByType<Paddle>();
        bricks = FindObjectsByType<Brick>(FindObjectsSortMode.None);
        popupText = FindFirstObjectByType<PopupTextResurrect>();
        deathText = FindFirstObjectByType<PopupTextDeath>();
    }

    private void LoadLevel(int levelId)
    {
        level = levelId;

        if (level > NUM_LEVELS)
        {
            // Start over again at level 1 once you have beaten all the levels
            // You can also load a "Win" scene instead
            LoadLevel(1);
            return;
        }

        SceneManager.sceneLoaded += OnLevelLoaded;
        SceneManager.LoadScene($"Level{level}");
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= OnLevelLoaded;
        FindSceneReferences();
    }

    public void OnBallMiss()
    {
        takeDamage(1);
ResetLevel();
    }

    private void ResetLevel()
    {
        paddle.ResetPaddle();
        ball.ResetBall();
    }

    private void GameOver()
    {
        if (isDead) return; // Prevent multiple game over triggers
        StartCoroutine(HandleGameOver());
    }
    private IEnumerator HandleGameOver() {
        isDead = true;
        if(ball != null) {
            ball.gameObject.SetActive(false); // Hide the ball
        }
        if (deathText != null) {
            deathText.Show("死", 2f);
        }
        yield return new WaitForSeconds(3f); // Wait for the death text to finish
        NewGame(); // Start a new game after the delay
        // Start a new game immediately
        // You can also load a "GameOver" scene instead
        
    }

    private void NewGame()
    {
        score = 0;
        health = maxHealth;
        bossHealth = 0;
        hasRessurection = true;
        isDead = false; // Reset the isDead flag for the new game

        LoadLevel(1);
    }

    public void OnBrickHit(Brick brick)
    {
        score += brick.points;

        if (Cleared()) {
            LoadLevel(level + 1);
        }
    }

    private bool Cleared()
    {
        for (int i = 0; i < bricks.Length; i++)
        {
            if (bricks[i].gameObject.activeInHierarchy && !bricks[i].unbreakable) {
                return false;
            }
        }

        return true;
    }

}
