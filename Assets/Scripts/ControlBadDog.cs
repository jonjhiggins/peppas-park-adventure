using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;

public class ControlBadDog : MonoBehaviour
{
	private int speed = 1;
	public GameObject player;
    public ParticleSystem dogParticles;
    public AudioClip dogImpact;
    public Score score;
    private AudioSource audioSource;
    private bool collided = false;
    private int scoreDecrement = 10;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
        if (collision.gameObject == player && !collided)
        {
            audioSource.PlayOneShot(dogImpact);
            dogParticles.Play();
            score.DecreaseScore(scoreDecrement);
            Invoke(nameof(DestroySelf), dogParticles.main.duration);
            collided = true;
        }
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }
}

