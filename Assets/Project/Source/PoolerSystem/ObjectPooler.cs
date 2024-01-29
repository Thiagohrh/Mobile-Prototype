using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public PoolerIdEnum tag;
        public GameObject prefab;
        public int size;
        public Transform holster;
    }

    public List<Pool> pools;
    public Dictionary<PoolerIdEnum, List<GameObject>> poolDictionary;

    protected void Start()
    {
        poolDictionary = new Dictionary<PoolerIdEnum, List<GameObject>>();
        StartPools();
    }

    private void StartPools()
    {
        foreach (Pool pool in pools)
        {
            List<GameObject> objectPool = new List<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject newObject = Instantiate(pool.prefab, pool.holster);
                newObject.SetActive(false);
                objectPool.Add(newObject);
            }
            
            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public bool SpawnFromPool(PoolerIdEnum tag, Vector2 position, Quaternion rotation, out GameObject selectedObject)
    {
        selectedObject = null;
        foreach (GameObject objectInPool in poolDictionary[tag])
        {
            if (objectInPool.activeSelf == false)
            {
                selectedObject = objectInPool;
                selectedObject.SetActive(true);
                selectedObject.transform.position = position;
                selectedObject.transform.rotation = rotation;
                return true;
            }
        }

        return false;
    }
}
