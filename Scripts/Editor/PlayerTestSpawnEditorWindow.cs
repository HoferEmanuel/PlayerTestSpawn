using UnityEngine;
using UnityEditor;

public class PlayerTestSpawnEditorWindow : EditorWindow
{
    private PlayerTestSpawner spawner;
    
    private void Start()
    {
        spawner = PlayerTestSpawner.Instance;
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