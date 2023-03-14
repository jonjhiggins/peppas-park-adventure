using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviours : MonoBehaviour
{

    public GameObject player;
    public Score score;
    private float speed;
    private int scoreIncrement = 10;
    private bool collided = false;

    void Start()
    {
        speed = Random.Range(0.5f, 5f);
    }

    void Update()
    {
        if (collided)
        {
            return;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            score.IncreaseScore(scoreIncrement);
            Destroy(gameObject);
            collided = true;
        }
    }
}
