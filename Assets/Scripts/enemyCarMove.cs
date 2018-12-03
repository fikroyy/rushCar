using UnityEngine;
using System.Collections;

public class enemyCarMove : MonoBehaviour {

	public float kecepatan = 8.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        // fungsi pergerakan enemy car
		transform.Translate (new Vector3(0,-6f,0) * kecepatan * Time.deltaTime);
	}
}