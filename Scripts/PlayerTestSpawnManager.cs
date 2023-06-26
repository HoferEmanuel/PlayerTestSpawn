using UnityEngine;

[ExecuteInEditMode]
public class PlayerTestSpawnManager : MonoBehviour
{
    public static PlayerTestSpawnManager Instance;

    public GameObject player;
    public int currentSpawnIndex = 0;
    public List<Vector3> spawns;

    private void Awake()
    {
        Instance = this;
    }

    public void ChangeSpawnPos(int targetVal)
    {
        currentSpawnIndex += targetVal;
        currentSpawnIndex = Mathf.Clamp(0, spawns.Count());
    }

    public void MovePlayerToSpawn() => player.transform.position = spawnPos;
}