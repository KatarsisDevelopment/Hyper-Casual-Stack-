using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectManager : MonoBehaviour
{
    public GameObject EggPrefab;
    public Transform InstantPoint;
    public List<GameObject> Egglist = new List<GameObject>();
    public float EggInstantTime = 1f;
    void Start()
    {
        StartCoroutine(EggInstanterEnum());
    }
    IEnumerator EggInstanterEnum()
    {
        while (true)
        {
            if (Egglist.Count < 5)
            {
                GameObject egg = Instantiate(EggPrefab, InstantPoint);
                egg.transform.position = new Vector3(InstantPoint.transform.position.x, Egglist.Count % 10 / 4f, InstantPoint.transform.position.z);
                Egglist.Add(egg);
                float last = Egglist.Count - 1;
            }
            yield return new WaitForSeconds(EggInstantTime);
        }
    }
}
