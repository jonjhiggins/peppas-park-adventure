using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;

public class ControlBadDog : MonoBehaviour
{
	private int speed = 1;
	public GameObject player;
    public Score score;
    private bool collided = false;
    private int scoreDecrement = 10;

    // Update is called once per frame
    void Update()
	{
        if (collided)
        {
            return;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
		transform.LookAt(player.transform);
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            score.DecreaseScore(scoreDecrement);
            Destroy(gameObject);
            collided = true;
        }
    }
}

