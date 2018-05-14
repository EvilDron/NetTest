using UnityEngine;

public class Push : MonoBehaviour {
    public float force = 10f;
    Rigidbody rg;
	void Start () {
        rg = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(new Vector3(force, 0, 0));
        }
	}
}
