using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerSpawn : NetworkBehaviour {

    private void Start()
    {
        print(isLocalPlayer);
    }

}
