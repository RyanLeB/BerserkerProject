using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HitboxBossEnraged : MonoBehaviour
{
    public int BossHealth = 20;
    public AudioSource MonsterSFX;

    
    public GameObject BossEnraged;
    public GameObject rock;
    public Text healthText;
    public GameObject canvas;
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
            BossHealth -= 1;

            if (BossHealth <= 0)
            {
                // Damage or destroy the enemy.
                Destroy(collision.gameObject);
                canvas.SetActive(true);
                rock.SetActive(true);

            }

        }
    }
}