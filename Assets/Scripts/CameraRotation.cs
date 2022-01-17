using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
	public float rotationSpeed = 5.0f;

	void Update() {
		float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
		transform.localRotation *= Quaternion.Euler(-mouseY, mouseX, 0);
		Camera camera = GetComponentInChildren<Camera>();
		camera.transform.localRotation *= Quaternion.Euler(-mouseY, 0, 0);
	}
}
