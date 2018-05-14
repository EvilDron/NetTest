using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class SpawnCube : NetworkBehaviour {

    [SerializeField]
    List<GameObject> objectsToSpawn;

    [SerializeField]
    Transform spawnPoint;
	
	void Start () {
        spawnPoint = GameObject.Find("Spawnpoint").transform;

    }
    private void Update()
    {
        if (!isLocalPlayer)
            return;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CmdSpawnObj(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CmdSpawnObj(1);
        }
    }

    [Command]
    public void CmdSpawnObj(int id)
    {
        RpcSpawmObj(id);
    }

    [ClientRpc]
    void RpcSpawmObj(int id)
    {
        Instantiate(objectsToSpawn[id], spawnPoint.position, spawnPoint.rotation);
    }
}
