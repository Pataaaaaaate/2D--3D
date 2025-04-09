using UnityEngine;

public class SpawnLocTp : MonoBehaviour
{
    public GameObject spawnLoc;
    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = spawnLoc.transform.position;
    }
}
