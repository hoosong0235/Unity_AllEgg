using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    public GameObject FoodPrefab;
    float deltaTime;
    float xLength = 5.0f;
    float yLength = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.deltaTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.deltaTime += Time.deltaTime;

        if (this.deltaTime >= 1.0f && GameObject.FindGameObjectsWithTag("Food").Length <= 25)
        {
            GameObject newFood = Instantiate(FoodPrefab) as GameObject;
            float randomX = Random.Range(-1 * this.xLength, 1 * this.xLength);
            float randomY = Random.Range(-1 * this.yLength, 1 * this.yLength);
            newFood.transform.position = new Vector3(randomX, randomY, 0.0f);

            this.deltaTime = 0.0f;
        }
    }
}
