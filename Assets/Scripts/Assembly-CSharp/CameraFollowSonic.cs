using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSonic : MonoBehaviour
{
	public Transform target;  // The object the camera will follow
	public float smoothSpeed = 0.125f;  // How smoothly the camera follows the object

	private void LateUpdate()
	{
		if (target == null)
			return;

		Vector3 targetPosition = target.position;
		targetPosition.y = transform.position.y;  // Maintain camera's Y position

		Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
		transform.position = smoothedPosition;
	}
}

