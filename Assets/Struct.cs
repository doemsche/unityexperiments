using UnityEngine;
using System.Collections;

public struct BoxParameters {
	public float width;
	public float height;
	public float depth;
	public Color color;
}

public class Struct : MonoBehaviour{
	public BoxParameters myParameters;
	public void Start () {
		myParameters.width = 2;
		myParameters.height = 3;
		myParameters.depth = 4;
		//myParameters.color = new Color(1,0,0,1);
	}
	public void UpdateCube(BoxParameters box){
		Vector3 size = new Vector3(box.width, box.height, box.depth);
		gameObject.transform.localScale = size;
		//gameObject.GetComponent<Renderer>().material.color = box.color;
	}

	public void Update(){
		float h = (100 * Mathf.Sin(Time.fixedTime))/10;
		myParameters.height = h;
		UpdateCube(myParameters);
	}
}

