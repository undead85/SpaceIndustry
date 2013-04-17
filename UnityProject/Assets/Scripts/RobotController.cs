using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour {
	
	public int hp = 100;
	// Use this for initialization
	void Start () {
		StartCoroutine(this.GettingOldCoroutine());
	}
	
	IEnumerator GettingOldCoroutine() {
		while(this.hp > 0){
			this.hp--;
			if (this.hp == 0) {
				Destroy(this.gameObject);
			}
			yield return 0;
		}
		yield break;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
