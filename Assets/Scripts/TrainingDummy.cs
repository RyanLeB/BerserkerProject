using UnityEngine;

public class TrainingDummy : MonoBehaviour
{

    public AudioSource HitSFX;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.CompareTag("Enemy"))
        {

            HitSFX.Play();
            
           
        }
    }
}