using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    public GameObject firework;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - firework.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = firework.transform.position + offset;
    }
}
