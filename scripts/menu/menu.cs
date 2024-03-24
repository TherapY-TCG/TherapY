using Godot;
using System;

public partial class Menu : Control {
    public void OnPlayPressed() {
        // TODO
    }

    public void OnCollectionPressed() {
        // TODO
    }

    public void OnSettingsPressed() {
        GetTree().ChangeSceneToFile("res://scenes/menu/settings_menu.tscn");
    }

    public void OnShopPressed() {
        GetTree().ChangeSceneToFile("res://scenes/menu/shop_menu.tscn");
    }

    public void OnExitPressed() {
        GetTree().Quit();
    }
}
