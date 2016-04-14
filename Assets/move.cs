using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public float min;
    public float max;
    public string input;

    float currentRotation;
    float currentMovement;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        currentRotation = gameObject.transform.rotation.y;
        currentMovement = Input.GetAxis(input);
       // if(currentMovement > 0 && currentMovement < 1)
       if(currentRotation >= min && currentRotation < max)
            currentRotation = currentMovement;

        gameObject.transform.rotation = new Quaternion(transform.rotation.x,Mathf.Abs(currentRotation), transform.rotation.z, transform.rotation.w);
        Debug.Log(currentRotation);
	}
}
