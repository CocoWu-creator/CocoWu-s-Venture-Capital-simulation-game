using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // This function is called when the user clicks on the object
    void OnMouseDown()
    {
        // Debugging message to confirm the click
        Debug.Log("Object clicked! Loading scene2...");

        // Load the next scene (scene2)
        SceneManager.LoadScene("scene2");
    }
}
