using UnityEngine;
using UnityEditor;

public class PlayerTestSpawnEditorWindow : EditorWindow
{
    private PlayerTestSpawner spawner;
    private GameObject spawnIndicator;

    private void Start()
    {
        spawner = PlayerTestSpawner.Instance;
    }

    private void GetSpawnIndicatorReference()
    {
        string[] guids = AssetDatabase.FindAssets("t:PlayerTestSpawn"); // Replace with the script name or class name

        if (guids.Length > 0)
        {
            string path = AssetDatabase.GUIDToAssetPath(guids[0]);
            playerTestSpawnIndicator = AssetDatabase.LoadAssetAtPath<PlayerTestSpawnIndicator>(path);

            if (playerTestSpawnIndicator == null)
                Debug.LogError("PlayerTestSpawnIndicator not found in the assets folder.");
        }
        else
            Debug.LogError("PlayerTestSpawnIndicator script not found in the assets folder.");
    }

    [MenuItem(DigitalDisaster/PlayerTestSpawner)]
    static void ToggleWindow()
    {
        PlayerTestSpawnEditorWindow window = (PlayerTestSpawnEditorWindow)GetWindow(typeof(PlayerTestSpawnEditorWindow));
        window.Show();
    }

    void OnGUI()
    {
        
    }
}