using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCenas : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("botPlay"))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                SceneManager.LoadScene("Level");
            }
        }
        if (GameObject.FindGameObjectWithTag("botQuit"))
        {
            if(Input.GetKey(KeyCode.Mouse0))
            {
                Application.Quit();

            }
        }
    }
}
