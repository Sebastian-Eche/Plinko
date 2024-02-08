using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnTransform;
    public Transform spawnTransform2;
    public Transform spawnTransform3;


    // Start is called before the first frame update
    void Start()
    {
        // Vector3 spawnPosition = spawnTransform.position;
        // Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Transform[] transforms = {spawnTransform, spawnTransform2, spawnTransform3};
        int randomNumber = Random.Range(0, 3);
        // float randomNumberX = Random.Range(0, 27f);
        // float randomNumberY = Random.Range(0, 10f);
        // float randomNumberZ = Random.Range(0, 20f);
        if (Input.GetKey(KeyCode.Space)){
            Vector3 spawnPosition = transforms[randomNumber].position;
            // Vector3 spawnPosition = new Vector3(0, randomNumberY, randomNumberZ);
            Debug.Log($"Name of spawner: {transforms[randomNumber].name} and spawn Position: {spawnPosition}");
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
    }

    
}
