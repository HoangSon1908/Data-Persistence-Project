using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Saveloadsystem : MonoBehaviour
{
    public TMP_InputField playerInputField; // Reference to the InputField component
    public string playerName; // Variable to store the saved text
    public static Saveloadsystem instance; 

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
    }
    // This function is called to save the text from the InputField
    public void SaveName()
    {
        // Check if the InputField is not null
            if (playerInputField != null)
            {
                // Save the text from the InputField to the playerName variable
                playerName = playerInputField.text;
                SceneManager.LoadScene(1);
            }
            else
            {
                Debug.LogWarning("InputField is not assigned!");
            }
    }
}
