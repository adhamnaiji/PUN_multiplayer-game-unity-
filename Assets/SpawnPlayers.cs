using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(player.name, SpawnPos, Quaternion.identity);

    }

    
}
