using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MexerKirby : MonoBehaviour
{
    float velFrente = 0.01f;
    float velTras = -0.01f;
    float velPulo = 2f;
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
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, velPulo, 0);
        }

        Vector3 direcao = Vector3.zero;
        transform.position += direcao;
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f);
        if (collision != null)
        {
            transform.position -= direcao;
            if (collision.CompareTag("colisor"))
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("colisor"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
