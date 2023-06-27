using UnityEngine;

[System.Serializable]
public class PlayerTestSpawn
{
    public Vector3 spawnPos;
    
    public PlayerTestSpawn(Vector3 spawnPos) => this.spawnPos = spawnPos;
}