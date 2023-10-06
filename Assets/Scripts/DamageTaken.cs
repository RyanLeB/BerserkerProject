
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageTaken : MonoBehaviour
{
    [SerializeField] private string newLevel;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level");
        }
    }
}
