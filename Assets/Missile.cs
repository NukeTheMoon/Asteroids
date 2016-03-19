using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    public WorldReference WorldReference;

    private CapsuleCollider _collider;
    private bool _selfdestruct = false;


    void Start()
    {
        _collider = GetComponent<CapsuleCollider>();
    }
	
	void Update ()
	{
	    _selfdestruct = true;
	    if (_collider.bounds.Intersects(WorldReference.VisibleWorld.bounds))
	    {
	        _selfdestruct = false;
	    }
	    if (_selfdestruct)
	    {
	        Destroy(gameObject);
	    }
	}
}
