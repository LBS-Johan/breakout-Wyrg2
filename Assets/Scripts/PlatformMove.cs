using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, -4.019f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x < 10.7f)
        {
            transform.position += (Vector3.right * (speed/100)*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -10.7f)
        {
            transform.position += (Vector3.left * (speed / 100) * Time.deltaTime);
        }
    }
}
