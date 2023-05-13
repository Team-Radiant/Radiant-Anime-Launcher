using UnityEngine;
using TMPro;

public class LoginSystem : MonoBehaviour
{
    public Canvas canvasToShow;
    public Canvas canvasToDelete;
    public TMP_InputField usernameInputField;
    public TMP_Text usernameText;

    private static bool isCanvasDeleted = false;

    private void Awake()
    {
        if (isCanvasDeleted)
        {
            Destroy(canvasToDelete.gameObject);
        }
    }

    public void Login()
    {
        if (!string.IsNullOrEmpty(usernameInputField.text))
        {
            Debug.Log("Login successful!");
            usernameText.text = "Welcome, " + usernameInputField.text + "!";
            canvasToShow.gameObject.SetActive(true);
            Destroy(canvasToDelete.gameObject);
            isCanvasDeleted = true;
        }
        else
        {
            Debug.Log("Login failed! Please enter a valid username.");
        }
    }
}
