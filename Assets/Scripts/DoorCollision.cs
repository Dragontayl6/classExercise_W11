using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCollision : MonoBehaviour
{
    // Called when another collider enters this trigger collider (3D physics)
    private void OnTriggerEnter(Collider other)
    {
        // Reload the currently active scene to "reset" it
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
