using Godot;
using System;

public partial class ShopMenu : Control {
    private MarginContainer _boostersPage;
    private MarginContainer _skinsPage;
    private MarginContainer _offersPage;

    public override void _Ready() {
        _boostersPage = GetNode<MarginContainer>("shop/mainPage/boostersPage");
        _skinsPage = GetNode<MarginContainer>("shop/mainPage/skinsPage");
        _offersPage = GetNode<MarginContainer>("shop/mainPage/offersPage");
    }

    public void OnBoostersPressed() {
        GD.Print("Boosters pressed");
        _boostersPage.Visible = true;
        _skinsPage.Visible = false;
        _offersPage.Visible = false;
    }

    public void OnSkinsPressed() {
        GD.Print("Skins pressed");
        _boostersPage.Visible = false;
        _skinsPage.Visible = true;
        _offersPage.Visible = false;
    }

    public void OnOffersPressed() {
        GD.Print("Offers pressed");
        _boostersPage.Visible = false;
        _skinsPage.Visible = false;
        _offersPage.Visible = true;
    }

    public void OnBackPressed() {
        GetTree().ChangeSceneToFile("res://scenes/menu/menu.tscn");
    }
}

