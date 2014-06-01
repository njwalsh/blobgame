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
	
	Vector3[] oldVertices;
	Vector3[] oldNodePositions;
	
	GameObject[] nodes;

	// Use this for initialization
	void Start () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		oldVertices = mesh.vertices;
		
		nodes = new GameObject[6] {node1, node2, node3, node4, node5, node6};
		oldNodePositions = new Vector3[6] {node1.transform.position, node2.transform.position, node3.transform.position, node4.transform.position, node5.transform.position, node6.transform.position};
	}
	
	// Update is called once per frame0
	void Update () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int i = 0;
        while (i < vertices.Length) {
			//for(int x = 0; x < 6; x++){
				//float dist = Mathf.Sqrt(Mathf.Pow((oldVertices[i].x - nodes[x].transform.position.x), 2) + Mathf.Pow((oldVertices[i].y - nodes[x].transform.position.y), 2) + Mathf.Pow((oldVertices[i].z - nodes[x].transform.position.z), 2));
				//Vector3 nodeDisplacement = nodes[x].transform.position - oldNodePositions[x];
				vertices[i] = vertices[i] /*+ (nodeDisplacement * dist)) */* Time.deltaTime;
			//}
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
	}
}
