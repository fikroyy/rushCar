using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

	public float carSpeed;
	public float maxRight = 2.11f;

	Vector3 posisi;

	public manageUI ui;

	void Start(){
		// deklare posisi
		ui = GetComponent<manageUI> (); 
		posisi = transform.position;
	}

	void Update(){
		// posisi batas kanan dan batas kiri
		posisi.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
		posisi.x = Mathf.Clamp (posisi.x,-2.05f,2.11f);
		transform.position = posisi;
	}
    // collision untuk car player
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
			ui.gameOverActivated();
		}
	}
}


