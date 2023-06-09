using System;

class Animal
{
    public string Espece { get; set; } = "Espece";
    public string Nom { get; set; } = "Animale";

    public Animal(string nom) => this.Nom = nom;
    public Animale(string espece) => this.Espece = espece;
}