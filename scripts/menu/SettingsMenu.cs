using Godot;
using System;

public partial class SettingsMenu : Control {
    public void OnBackPressed() {
        GetTree().ChangeSceneToFile("res://scenes/menu/menu.tscn");
    }
}
