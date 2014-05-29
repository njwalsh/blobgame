using UnityEngine;
using System.Collections;

public class BlobPhysics_Script : MonoBehaviour {
	
	public GameObject texturePlane;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int i = 0;
        while (i < vertices.Length) {
            vertices[i] += Vector3.up * Time.deltaTime;
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
	}
}
