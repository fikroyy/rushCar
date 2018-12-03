using System.Collections;
using UnityEngine;

public class carRandom : MonoBehaviour {

	public GameObject[] mobil;
	public float posisiMaksimum = 1.29f;
	public float waktuDelay = 1f;
    int noMobil;
	float waktu;



	// Use this for initialization
	void Start () {
		waktu = waktuDelay; 

	}
	
	// Update is called once per frame
	void Update () {
		// fungsi untuk menentukan fungsi mobil random dalam skala -1.29f sampai 1.29f
        waktu -= Time.deltaTime;
		if (waktu <= 0) {
			Vector3 posisiMobil = new Vector3 (Random.Range (-1.29f, 1.29f), transform.position.y, transform.position.x);
            noMobil = Random.Range(0, 4);
			Instantiate (mobil[noMobil], posisiMobil, transform.rotation);	
			waktu = waktuDelay;
		}
			
		} 
}
