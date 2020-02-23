using UnityEngine;

public class PickUpObstacle : MonoBehaviour
{
	private Camera _camera;
	private GameObject pickedObstacle;
	private float pickedDistance;

	// Start is called before the first frame update
	void Start()
	{
		_camera = GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.tag == "Obstacle")
				{
					pickedObstacle = hitObject;
					pickedDistance = (hit.point - transform.position).magnitude;
				}
			}
		}
		else if (Input.GetMouseButtonUp(0) && pickedObstacle != null)
		{
			pickedObstacle = null;
		}
		else if (pickedObstacle != null)
		{
			Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
			Vector3 targetPoint = transform.position + pickedDistance*ray.direction.normalized;
			pickedObstacle.transform.position = targetPoint;
		}
	}
}
