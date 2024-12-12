using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBreakables : MonoBehaviour
{
    public int breakablesLeft = 36;
    public GameObject Breakable;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-10.5f, 4.58f);
        Instantiate(Breakable);
        for(int i = 0; i < 8; i++)
        {
            transform.position = new Vector2(transform.position.x + 2.6f, 4.58f);
            Instantiate(Breakable, transform.position, transform.rotation);
        }
        transform.position = new Vector2(-10.5f, transform.position.y - 1);
        for(int J = 0; J < 3; J++)
        {
            for (int i = 0; i < 9; i++)
            {
                Instantiate(Breakable, transform.position, transform.rotation);
                transform.position = new Vector2(transform.position.x + 2.6f, transform.position.y);
            }
            transform.position = new Vector2(-10.5f, transform.position.y - 1);
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(breakablesLeft == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
