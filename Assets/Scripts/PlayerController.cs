using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;

    float screenHalfW;
    float halfPlayerWidth;
    // Start is called before the first frame update
    void Start()
    {
        halfPlayerWidth = transform.localScale.x / 2;
        screenHalfW = Camera.main.aspect*Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 InputDir = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        Vector2 dir = InputDir.normalized;
        Vector2 velocity = dir*speed;

        transform.Translate(velocity*Time.deltaTime);

        if (transform.position.x  > screenHalfW + halfPlayerWidth)
        {
            transform.position = new Vector2(-screenHalfW, transform.position.y);
        }

        if (transform.position.x  < -screenHalfW - halfPlayerWidth)

        {
            transform.position = new Vector2(screenHalfW, transform.position.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "Falling Block")
        Destroy(gameObject);
    }
}
