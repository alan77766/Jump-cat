using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public GameObject Player;
    Vector3 playerPos;
    public GameObject hpGauge;
    int Life = 10;
    public GameObject CatfoodPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeArrow", 0, 1.0f);
        InvokeRepeating("MakeCatfood", 0, 1.0f);

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
    void MakeCatfood()
    {
        int px = Random.Range(-3, 4);
        float py = playerPos.y + 6;
        Instantiate(CatfoodPrefab, new Vector3(px, py, 0), Quaternion.identity);
    }
    public void DecreaseHp()
    {
        Life -= 1;
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void IncreaseHp()
    {
        Life += 1;
        hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }
}

