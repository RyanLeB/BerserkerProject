using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DamageTakenBoss : MonoBehaviour
{
    [SerializeField] AudioSource hurtSFX;

    static public int health = 20;
    public Text healthText;
    public float timestamp = 0f;
    public float delay = 1f;
    

    
    private void Update()
    {
        if (healthText != null)
        {
            healthText.text = health.ToString();

        }


    }




    private void TakeDamage(int damage)
    {
        if (Time.time > timestamp + delay)
        {
            hurtSFX.Play();
            health -= damage;
            timestamp = Time.time;
        }
        
    }




    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage(1);
            

            if (health == 0)
            {

                SceneManager.LoadScene("BossLVL");
                health = 20;
            }
        }






    }
}
