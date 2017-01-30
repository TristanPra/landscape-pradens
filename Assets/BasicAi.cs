using UnityEngine;
using System.Collections;

public class BasicAi : MonoBehaviour {

	void Start () {
	
	}

	public Transform target;
	public Transform myTransform; void Update () { transform.LookAt(target);


			transform.Translate (Vector3.forward * 5 * Time.deltaTime);
		}
}
