using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(EdgeCollider2D))]
public class InvertCercleGenerator : MonoBehaviour {

	public float edgesPerArcLength;

	// Use this for initialization
	void Start () {
		float radius = GetComponent<CircleCollider2D>().radius;
		int totalEdges = (int)(radius * edgesPerArcLength);

		EdgeCollider2D edgeCollider = GetComponent<EdgeCollider2D>();
		Vector2[] points = new Vector2[totalEdges];

		for (int i = 0; i < totalEdges; i++)
		{
			float angle = 2 * Mathf.PI * i / totalEdges;
			float x = radius * Mathf.Cos(angle);
			float y = radius * Mathf.Sin(angle);

			points[i] = new Vector2(x, y);
		}
		edgeCollider.points = points;
	}
}
