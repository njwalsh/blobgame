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
	
	private Vector3 node1Pos;
	
	Vector3[] verticesOrg;

	// Use this for initialization
	void Start () {
		node1Pos = node1.transform.localPosition;
		
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		verticesOrg = mesh.vertices;
	}
	
	// Update is called once per frame
	void Update () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int i = 0;
        while (i < vertices.Length) {
			float dist = Mathf.Sqrt(Mathf.Pow((vertices[i].x - node1.transform.position.x), 2f) + Mathf.Pow((vertices[i].y - node1.transform.position.x), 2f) + Mathf.Pow((vertices[i].z - node1.transform.position.z), 2f))/10f;
            vertices[i] = vertices[i] /*+ (node1.transform.localPosition - node1Pos) * Time.deltaTime*/;
			Vector3 disp = node1.transform.localPosition - node1Pos;
			Debug.Log(disp);
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
	}
}
