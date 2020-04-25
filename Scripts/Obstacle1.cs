using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Obstacle1 : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
    





