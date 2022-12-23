using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public GameObject Player;
    Vector3 playerPos;
    public GameObject hpgauge;

// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeArrow", 0, 1.0f);
    }




    // Update is called once per frame
    void Update()
    {
        playerPos = Player.transform.position;
    }
    void MakeArrow()
    {
        int px = Random.Range(-3, 4);
        float py = playerPos.y + 6;
        Instantiate(ArrowPrefab,new Vector3(px,py,0), Quaternion.identity);
    }
    
}

