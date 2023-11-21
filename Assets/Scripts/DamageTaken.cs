
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DamageTaken : MonoBehaviour
{
    [SerializeField] AudioSource hurtSFX;
    
    static public int health = 3;
    public Text healthText;

    private void Update()
    {
        healthText.text = health.ToString();


    }




    static void TakeDamage(int damage)
    {
        health -= damage;
    }



    [SerializeField] private string newLevel;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage(1);
            hurtSFX.Play();

            if(health == 0)
            {
                SceneManager.LoadScene("VillageLVL");
                health = 3;
            }
        }
        
        
        
            
          
        
    }
}
