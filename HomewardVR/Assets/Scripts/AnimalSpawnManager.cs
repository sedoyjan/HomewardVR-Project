﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnedAnimal;

    [SerializeField]
    private Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimalSpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator AnimalSpawnRoutine()
    {
        while (true)
        {
            GameObject animal = Instantiate(spawnedAnimal[Random.Range(0, 1)], spawnPoints[Random.Range(0, 12)]);

            animal.transform.localPosition = Vector3.zero;

            yield return new WaitForSeconds(Random.Range(4f, 8f));
        }

    }
}
