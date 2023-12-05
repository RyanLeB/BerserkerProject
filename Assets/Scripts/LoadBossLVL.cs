using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBossLVL : MonoBehaviour
{
    [SerializeField] private string newLevel;
    public void LoadLVL()
    {
        SceneManager.LoadScene("BossLVL");
    }
}
