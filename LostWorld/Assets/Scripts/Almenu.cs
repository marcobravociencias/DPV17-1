using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Almenu : MonoBehaviour
{

    public void ToMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
