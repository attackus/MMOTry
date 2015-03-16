using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour {

    public GameObject spellPrefab;

	// Use this for initialization
	void Start () {
        if (spellPrefab == null)
        {
            Debug.Log("SpellCast script does not have a spell prefab attached. Disabling script.");
            this.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(spellPrefab, transform.position, transform.rotation);
        }
	}
}
