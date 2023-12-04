using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DamageTakenMirror : MonoBehaviour
{
    [SerializeField] AudioSource hurtSFX;

    static public int health = 3;
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
            TakeDamage(1);
            hurtSFX.Play();

            if (health == 0)
            {

                SceneManager.LoadScene("MirrorLVL");
                health = 3;
            }
        }






    }
}
