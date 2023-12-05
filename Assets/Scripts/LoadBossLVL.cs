using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBossLVL : MonoBehaviour
{
    [SerializeField] private string newLevel;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("BossLVL");

        }
        
    }
}
