using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
	private int forwardSpeed = 1;
	private int turnSpeed = 36;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float verticalInput = Input.GetAxis("Vertical") + 2;
        float horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * forwardSpeed);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);
    }
}

