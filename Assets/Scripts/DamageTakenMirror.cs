using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DamageTakenMirror : MonoBehaviour
{
    [SerializeField] AudioSource hurtSFX;

    static public int health = 20;
    [SerializeField] private Text healthText;
    [SerializeField] private float timestamp = 0f;
    [SerializeField] private float delay = 1f;
    

    
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
            TakeDamage(2);
            

            if (health == 0)
            {

                SceneManager.LoadScene("MirrorLVL");
                health = 20;
            }
        }






    }
}
