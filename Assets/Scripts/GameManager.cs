using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject walls;
    [SerializeField] GameObject deathCollider;
    [SerializeField] Transform camerTransform;
    [SerializeField] Transform playerTransform;
    public GameObject canvasObj;
    [SerializeField] float riseValue;
    void Start()
    {
        canvasObj.SetActive(false);
    }

    void Update()
    {
        walls.transform.localScale = new Vector3(walls.transform.localScale.x, walls.transform.localScale.y + riseValue * Time.deltaTime, walls.transform.localScale.z);
        deathCollider.transform.localScale = new Vector3(deathCollider.transform.localScale.x, deathCollider.transform.localScale.y + riseValue * Time.deltaTime, deathCollider.transform.localScale.z);
        camerTransform.position = new Vector3(camerTransform.position.x, playerTransform.position.y, camerTransform.position.z);
    }
    
    public void GameOver()
    {
        canvasObj.SetActive(true);
        Time.timeScale = 0;
    }
}
