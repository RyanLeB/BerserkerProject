using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMirrorLVL : MonoBehaviour
{
    [SerializeField] private string newLevel;
    public void LoadLVL()
    {
        SceneManager.LoadScene("MirrorLVL");
    }
}
