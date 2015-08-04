using UnityEngine;
using System.Collections;
public class UseStruct : MonoBehaviour
{
	BoxParameters ThatBox;
	//uses globally accessible BoxParameters struct!
	//Use this for initialization
	void Start ()
	{
	}
	//Update is called once per frame
	void Update ()
	{
		Vector3 cuboPos = GameObject.Find ("Cubo").transform.position;
		ThatBox =
			GameObject.Find("Box1").GetComponent<Struct>().myParameters;
		gameObject.transform.position =
			new Vector3(cuboPos.x,ThatBox.height*0.5f, cuboPos.z);
	}
}