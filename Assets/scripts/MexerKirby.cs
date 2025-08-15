using UnityEngine;
using UnityEngine.Rendering;

public class MexerKirby : MonoBehaviour
{
    float velFrente = 1f;
    float velTras = -1f;
    float velPulo = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(velFrente, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(velTras, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, velPulo, 0);
        }
    }
}
