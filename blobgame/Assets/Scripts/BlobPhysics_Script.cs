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
	public GameObject node7;
	
	Vector3[] oldVertices;
	Vector3[] oldNodePositions;
	
	float originalDist;
	
	GameObject[] nodes;

	// Use this for initialization
	void Start () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		oldVertices = mesh.vertices;
		
		originalDist = Mathf.Sqrt(Mathf.Pow((node7.transform.position.x - node1.transform.position.x), 2) + Mathf.Pow((node7.transform.position.y - node1.transform.position.y), 2) + Mathf.Pow((node7.transform.position.z - node1.transform.position.z), 2));
		
		nodes = new GameObject[7] {node1, node2, node3, node4, node5, node6, node7};
		oldNodePositions = new Vector3[7] {node1.transform.localPosition, node2.transform.localPosition, node3.transform.localPosition, node4.transform.localPosition, node5.transform.localPosition, node6.transform.localPosition, node7.transform.localPosition};
	}
	
	// Update is called once per frame0
	void Update () {
		Mesh mesh = texturePlane.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int i = 0;
		float dist = 0;
		Vector3 nodeDisplacement = Vector3.up;
        while (i < vertices.Length) {
			for(int x = 0; x < 7; x++){
			//int x  = 0;
				dist = Mathf.Sqrt(Mathf.Pow((oldVertices[i].x - nodes[x].transform.localPosition.x), 2) + Mathf.Pow((oldVertices[i].y - nodes[x].transform.localPosition.y), 2) + Mathf.Pow((oldVertices[i].z - nodes[x].transform.localPosition.z), 2));
				//Debug.Log("originalDist: " + originalDist);
				//Debug.Log("cenpos: " + node7.transform.position + "nodepos: " + nodes[x].transform.position);
				Vector3 v = node7.transform.position - nodes[x].transform.position;
				//Debug.Log("v: " + v);
				Vector3 u = Vector3.Normalize(v);
				//Debug.Log("u: " + u);
				Vector3 result = nodes[x].transform.position + (originalDist * u);
				//Debug.Log("result: " + result);
				result = nodes[x].transform.position - result;
				//Debug.Log("result: " + result);
				nodeDisplacement = new Vector3(result.x, 0f, result.y);
				//Debug.Log("nodeDisplacement: " + nodeDisplacement);
				
				vertices[i] = oldVertices[i] + (nodeDisplacement * dist);
			}
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
	}
}
