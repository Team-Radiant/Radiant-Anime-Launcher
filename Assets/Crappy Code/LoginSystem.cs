using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginSystem : MonoBehaviour
{
    public TMP_InputField usernameInputField;
    public TMP_Text usernameText;

    public void Login()
    {
        if (!string.IsNullOrEmpty(usernameInputField.text))
        {
            Debug.Log("Login successful!");
            SceneManager.LoadScene("RadiantLauncherRewrite");
            usernameText.text = "Welcome, " + usernameInputField.text + "!";
        }
        else
        {
            Debug.Log("Login failed! Please enter a valid username.");
        }
    }
}
