using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginPageScript : MonoBehaviour
{
    public TMP_InputField usernameField;
    public TMP_InputField passwordField;
    public TextMeshProUGUI errortext;
    public void OnSubmitLogin()
    {
        string username = usernameField.text;
        string password = passwordField.text;

        Debug.Log("USERNAME: " + username + " PASSWORD: " + password);

        string logincheckmessage = CheckLoginInfo(username, password);
        

        if(username == "admin" && password == "admin")
        {
            Debug.Log("Login Successful");
            UnityEngine.SceneManagement.SceneManager.LoadScene("TEST");
        }
        else
        {
            Debug.Log("Login Failed");
            errortext.text = "Login Failed";
        }
        errortext.text = logincheckmessage;
    }

    private string CheckLoginInfo(string username, string password)
    {   
        string returnstring = "";
        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password)){
            returnstring = "Both Username and Password are empty";
        }
        else if (string.IsNullOrEmpty(username)){ 
            returnstring = "Username is empty"; }
        else if (string.IsNullOrEmpty(password)){
            returnstring = "Password is empty"; }
        else
        {
            returnstring = "";
        }

        Debug.Log("Return STRING: " + returnstring);
        return returnstring;
    }
}
