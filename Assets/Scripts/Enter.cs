using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger!");
            SceneManager.LoadScene("Vault");
        }
    }
}
