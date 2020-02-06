using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSpeed = 50.0f;
	
	
	void Update () {
        float translation = CrossPlatformInputManager.GetAxis ("Vertical") * speed * 3;
        float rotation = CrossPlatformInputManager.GetAxis ("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, -translation);
        transform.Rotate(0, rotation, 0);
	}
}
