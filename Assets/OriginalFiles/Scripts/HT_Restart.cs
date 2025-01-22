using UnityEngine;
using UnityEngine.SceneManagement;

public class HT_Restart : MonoBehaviour
{
    public void OnMouseDown()
    {
        // SceneManager toegevoegd in plaats van LoadLevel.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
