using UnityEngine;
using System.Collections;

public class BlobPhysics_Script : MonoBehaviour {
	
	public GameObject texturePlane;
	
	public GameObject node1;
	public GameObject node2;
	public GameObject node3;
	public GameObject node4;
	public GameObject node5;
	public GameObject node6;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int i = 0;
        while (i < vertices.Length) {
			float dist = Mathf.Sqrt(Mathf.Pow((vertices[i].x - node1.transform.position.x), 2f) + Mathf.Pow((vertices[i].y - node1.transform.position.x), 2f) + Mathf.Pow((vertices[i].z - node1.transform.position.z), 2f));
			dist = Mathf.Clamp(dist, 0, 1)/10f;
            vertices[i] += node1.transform.position * dist * Time.deltaTime;
			dist = Mathf.Sqrt(Mathf.Pow((vertices[i].x - node2.transform.position.x), 2f) + Mathf.Pow((vertices[i].y - node2.transform.position.x), 2f) + Mathf.Pow((vertices[i].z - node2.transform.position.z), 2f));
			dist = Mathf.Clamp(dist, 0, 1)/10f;
			vertices[i] += node2.transform.position * dist * Time.deltaTime;
			dist = Mathf.Sqrt(Mathf.Pow((vertices[i].x - node3.transform.position.x), 2f) + Mathf.Pow((vertices[i].y - node3.transform.position.x), 2f) + Mathf.Pow((vertices[i].z - node3.transform.position.z), 2f));
			dist = Mathf.Clamp(dist, 0, 1)/10f;
			vertices[i] += node3.transform.position * dist * Time.deltaTime;
			dist = Mathf.Sqrt(Mathf.Pow((vertices[i].x - node4.transform.position.x), 2f) + Mathf.Pow((vertices[i].y - node4.transform.position.x), 2f) + Mathf.Pow((vertices[i].z - node4.transform.position.z), 2f));
			dist = Mathf.Clamp(dist, 0, 1)/10f;
			vertices[i] += node4.transform.position * dist * Time.deltaTime;
			dist = Mathf.Sqrt(Mathf.Pow((vertices[i].x - node5.transform.position.x), 2f) + Mathf.Pow((vertices[i].y - node5.transform.position.x), 2f) + Mathf.Pow((vertices[i].z - node5.transform.position.z), 2f));
			dist = Mathf.Clamp(dist, 0, 1)/10f;
			vertices[i] += node5.transform.position * dist * Time.deltaTime;
			dist = Mathf.Sqrt(Mathf.Pow((vertices[i].x - node6.transform.position.x), 2f) + Mathf.Pow((vertices[i].y - node6.transform.position.x), 2f) + Mathf.Pow((vertices[i].z - node6.transform.position.z), 2f));
			dist = Mathf.Clamp(dist, 0, 1)/10f;
			vertices[i] += node6.transform.position * dist * Time.deltaTime;
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
	}
}
