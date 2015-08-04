using UnityEngine;
using System.Collections;

public class Chain : MonoBehaviour {

	public GameObject[] boxes;
	public int numObjects;
	public PrimitiveType primitiveType;
	[Range(1.2f,2.0f)]
	public float spacing;



	// Use this for initialization
	void Start () {
		boxes = new GameObject[numObjects];
		for(int i = 0; i < numObjects; i++){
			GameObject box = GameObject.CreatePrimitive(getRandomPrimitive());
			box.GetComponent<Renderer>().material.color = getRandomColor();
			box.name = "Box"+i.ToString();
			box.AddComponent<Struct>();
			boxes[i] = box;
		}
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		foreach (GameObject go in boxes){
			float wave = Mathf.Sin(Time.fixedTime + i);
			go.transform.position = new Vector3(i * spacing, wave, 0);
			i++;
		}
	}

	Color getRandomColor(){
		switch(Random.Range (0,3)){
		case 0:
			return Color.blue;
			break;
		case 1:
			return Color.red;
			break;
		case 2:
			return Color.green;
			break;
		default:
			return Color.green;
		}
	}

	PrimitiveType getRandomPrimitive(){
		switch(Random.Range (0,3)){
			case 0:
				return PrimitiveType.Cube;
				break;
			case 1: 
				return PrimitiveType.Sphere;
				break;
			case 2: 
				return PrimitiveType.Capsule;
				break;
			default:
				return PrimitiveType.Capsule;
		}
	}
}
