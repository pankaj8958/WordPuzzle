using UnityEngine;

public class ObjectGenerator : MonoBehaviour {

    public GameObject objSpawn;

    private void Start()
    {
        InvokeRepeating("SpawnObject",1f,0.5f);
    }

    void SpawnObject ()
    {
        if (objSpawn != null)
        {
            GameObject obj = Instantiate(objSpawn);
            obj.transform.position = this.transform.position;
        }
    }
}
