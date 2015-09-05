using UnityEngine;
using System.Collections;

public class MoveOffSet : MonoBehaviour {

	public float speed;
	private float offset;
	private Material currentMaterial;

	void Start () {
		currentMaterial = GetComponent<Renderer>().material;
		// currentMaterial = renderer.material;
	}
	
	void Update () {
		offset = 0.01f * Time.time;

		currentMaterial.SetTextureOffset("_MainTex", new Vector2(offset * speed, 0));
	}
}
