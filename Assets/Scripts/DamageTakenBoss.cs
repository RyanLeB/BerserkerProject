using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DamageTakenBoss : MonoBehaviour
{
    [SerializeField] AudioSource hurtSFX;

    static public int health = 100;
    public Text healthText;

    private void Update()
    {
        if (healthText != null)
        {
            healthText.text = health.ToString();

        }


    }




    private void TakeDamage(int damage)
    {
        health -= damage;
        
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage(5);
            hurtSFX.Play();

            if (health == 0)
            {

                SceneManager.LoadScene("BossLVL");
                health = 100;
            }
        }






    }
}
