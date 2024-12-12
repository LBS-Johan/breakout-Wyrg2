using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMoveDown : MonoBehaviour
{
    public int breakableAmount = 36;
    public float ballSpeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        ballSpeed = ballSpeed * -1;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(ballSpeed, ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(breakableAmount == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Breakable"))
        {
            breakableAmount -= 1;
        }
    }

}
