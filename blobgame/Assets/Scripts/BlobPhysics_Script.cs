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
		oldNodePositions = new Vector3[6] {node1.transform.localPosition, node2.transform.localPosition, node3.transform.localPosition, node4.transform.localPosition, node5.transform.localPosition, node6.transform.localPosition};
	}
	
	// Update is called once per frame0
	void Update () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int i = 0;
        while (i < vertices.Length) {
			for(int x = 0; x < 6; x++){
			//int x  = 1;
				float dist = Mathf.Sqrt(Mathf.Pow((oldVertices[i].x - nodes[x].transform.localPosition.x), 2) + Mathf.Pow((oldVertices[i].y - nodes[x].transform.localPosition.y), 2) + Mathf.Pow((oldVertices[i].z - nodes[x].transform.localPosition.z), 2));
				Vector3 nodeDisplacement = nodes[x].transform.localPosition - oldNodePositions[x];
				nodeDisplacement = new Vector3(nodeDisplacement.x, 0f, nodeDisplacement.z);
				vertices[i] = oldVertices[i] + (nodeDisplacement);
			}
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
	}
}
