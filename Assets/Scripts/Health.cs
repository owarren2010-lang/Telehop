using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHearts();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
             currentHealth = 0;

            UpdateHearts();
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void Heal(int amount) 
    {
    currentHealth += amount;
        if (currentHealth > maxHealth)
        {
        currentHealth = maxHealth;

            UpdateHearts();
        }
    }
    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
        if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
    void Die()
    {
        Debug.Log("Player Died");
        SceneManager.LoadScene("Game Over");
    }
}
