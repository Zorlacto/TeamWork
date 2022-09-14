using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.VisualScripting;

public class SpawnDodgeBalls : MonoBehaviour
{
    public GameObject[] numberboxes;

    public GameObject startPos;

    [SerializeField] float timer;
    public float spawnPerSecond;

    [SerializeField] int index;

    [SerializeField] float boxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        spawnPerSecond = Random.Range(2f, 4f);
        timer = 0;
        //Debug.Log(numberboxes.Length);
        boxSpeed = Random.Range(8f, 12f);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > spawnPerSecond)
        {
            index = Random.Range(0, numberboxes.Length);

            Object obj = Instantiate(numberboxes[index], startPos.transform.position, transform.rotation);
            //obj.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, boxSpeed);
            spawnPerSecond += Random.Range(1f, 3f);
            Destroy(obj, 6);
        }
    }
}
