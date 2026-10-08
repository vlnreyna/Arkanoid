using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Ball")) 
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
