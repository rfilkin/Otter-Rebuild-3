﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class MeteorShower : MonoBehaviour {

	[SerializeField] Meteor meteorPrefab;
	[SerializeField] RectTransform targetDirection;
	[SerializeField] float speed;
	[SerializeField] float distance;
	[SerializeField] float rotationSpeed;
	[SerializeField] float meteorsPerSecond;

	RectTransform spawnArea;

	float meteorSpawnTimer = 0f;


	// Use this for initialization
	void Awake () {
		spawnArea = GetComponent<RectTransform>();
		meteorsPerSecond = meteorsPerSecond <= 0 ? 1 : meteorsPerSecond;
	}
	
	// Update is called once per frame
	void Update () {
		meteorSpawnTimer -= Time.deltaTime;
		if (meteorSpawnTimer <= 0)
			SpawnMeteor();
	}

	void SpawnMeteor(){
		float x = Random.value * spawnArea.rect.width * 2;
		float y = Random.value * spawnArea.rect.height * 2;

		x = spawnArea.transform.position.x + x - spawnArea.rect.width;
		y = spawnArea.transform.position.y + y - spawnArea.rect.height;

		Vector2 dir = targetDirection.position - spawnArea.position;

		float lifeSpan = distance / speed;


		Meteor m = Instantiate(meteorPrefab, spawnArea.parent);
		m.Init(lifeSpan, dir, rotationSpeed, x, y);

		meteorSpawnTimer = 1/meteorsPerSecond;
	}
}
