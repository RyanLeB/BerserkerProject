using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HitboxBoss : MonoBehaviour
{
    public int BossHealth = 20;
    public AudioSource MonsterSFX;

    public Text healthText;

    private void Update()
    {
        if (healthText != null)
        {
            healthText.text = BossHealth.ToString();

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.CompareTag("Enemy"))
        {

            MonsterSFX.Play();
            BossHealth -= 2;
            
            if (BossHealth <= 0) 
            {
                // Damage or destroy the enemy.
                Destroy(collision.gameObject);
            
            }
            
        }
    }
}