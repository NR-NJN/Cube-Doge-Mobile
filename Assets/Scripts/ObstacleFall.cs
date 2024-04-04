using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class ObstacleFall : MonoBehaviour
{
    public Vector2 fallSpeed;
    float speed;
    void Start()
    {
        speed = Mathf.Lerp(fallSpeed.x, fallSpeed.y, Settings.GetMaxDifficulty());
    }
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
