using UnityEngine;

class Spikes : MonoBehaviour {
	
	[SerializeField] GameObject[] pops;
	int index;
	
	void OnTriggerEnter2D(Collider2D collider) {
		pops[index].transform.position = collider.transform.position;
		pops[index].SetActive(true);
		index = (index + 1) % pops.Length;
		collider.transform.position = Vector3.down * 100f;
	}
}
