using UnityEngine;

public class Stalker : MonoBehaviour
{
	public Transform player;
	public Transform overview;

	private Vector3 playerViewOffset;
	private Quaternion playerViewRotation;

	// Start is called before the first frame update
	void Start()
	{
		playerViewOffset = transform.position - player.transform.position;
		playerViewRotation = transform.rotation;
	}

	// Update is called once per frame
	void LateUpdate()
	{
		if (Input.GetKey("m"))
		{
			transform.position = overview.position;
			transform.rotation = overview.rotation;
		}
		else
		{
			transform.position = player.transform.position + playerViewOffset;
			transform.rotation = playerViewRotation;
		}
	}
}
