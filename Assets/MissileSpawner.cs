using UnityEngine;
using System.Collections;

public class MissileSpawner : MonoBehaviour
{
    public Transform World;
    public GameObject MissilePrefab;
    public float MissileSpeed = 1000.0f;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
            var missile = (GameObject) Instantiate(MissilePrefab, transform.position, transform.parent.rotation);
	        missile.transform.parent = World;
            PropelForward(missile);
	    }
	}

    void PropelForward(GameObject missile)
    {
        var direction = transform.parent.forward;
        Debug.Log(direction);
        var rigidbody = missile.GetComponent<Rigidbody>();
        rigidbody.AddForce(direction * MissileSpeed);
        rigidbody.drag = 0;
    }
}
