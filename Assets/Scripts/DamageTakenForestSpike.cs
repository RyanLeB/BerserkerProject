using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DamageTakenForestSpike : MonoBehaviour
{
    [SerializeField] AudioSource hurtSFX;

    static public int health = 20;
    public Text healthText;

    private void Update()
    {
        if (healthText != null)
        {
            healthText.text = health.ToString();

        }


    }




    static void TakeDamage(int damage)
    {
        health -= damage;
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage(20);
            hurtSFX.Play();

            if (health == 0)
            {

                SceneManager.LoadScene("ForestLVL");
                health = 20;
            }
        }






    }
}
