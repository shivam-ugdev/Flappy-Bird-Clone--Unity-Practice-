using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    
    public float force;
    private Rigidbody2D rb;
    private Animator anim;

    private int Points = 0;
    public Text ScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           ClickedOnMouse();

        }
        else
        {
            anim.SetBool("Clicked",false);
        }
    }

    void ClickedOnMouse()
    {
        rb.linearVelocity = Vector2.up * force;
        anim.SetBool("Clicked",true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // use to spawn the character at atarting point after collision

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        UI.instance.OpenEndScreen();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PipesScore")
        {
            Points++;
            ScoreText.text = Points.ToString();
        }
    }

    

}
