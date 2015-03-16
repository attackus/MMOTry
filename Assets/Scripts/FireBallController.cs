using UnityEngine;
using System.Collections;

public class FireBallController : MonoBehaviour {

    public float fireAttackSpeed = 1f;

    public GameObject explosionPrefab;

	// Use this for initialization
	void Start () {
        if (explosionPrefab == null)
        {
            Debug.Log("ExplodeOnImpact Script does not have an explosion prefab attached. Disabling Script.");
            this.enabled = false;
        }
	}

    void Update()
    {
        transform.Translate(Vector3.forward * fireAttackSpeed);
        Destroy(gameObject, 3);
    }

    void OnTriggerEnter(Collider col)
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
