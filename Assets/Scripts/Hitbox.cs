using UnityEngine;

public class Hitbox : MonoBehaviour
{
    
    public AudioSource MonsterSFX;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.CompareTag("Enemy"))
        {

            MonsterSFX.Play();
            
            
            // Damage or destroy the enemy.
            Destroy(collision.gameObject);
        }
    }
}