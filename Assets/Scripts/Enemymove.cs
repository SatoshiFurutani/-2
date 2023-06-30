using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    [SerializeField] private float enemySpeed;
    [SerializeField] private float enemyLifeTime;
    private GameObject data;
    private Data dataCs;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, enemySpeed) * Time.deltaTime);

        enemyLifeTime = enemyLifeTime - Time.deltaTime;
        if(enemyLifeTime < 0)
        {
            Destory(this.gameObject);
        }

    }

    private void OnTrigerEnter(Collider other)
    {
        dataCs.score++;
        Destory(this.gameObject);
    }
}
