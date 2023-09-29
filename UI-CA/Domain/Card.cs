﻿using System.Collections.Generic;

namespace MagicTheGatheringManagement.Domain;

public class Card
{
    public Card(string name, CardType type, List<CardAbility> cardAbilities, List<CardColour> cardColours, int manaCost, double price, string description, bool isFoil)
    {
        Name = name;
        Type = type;
        CardAbilities = cardAbilities;
        CardColours = cardColours;
        ManaCost = manaCost;
        Price = price;
        Description = description;
        IsFoil = isFoil;
    }

    public string Name { get; set; }
    public CardType Type { get; set; }
    public List<CardAbility>? CardAbilities { get; set; }
    public List<CardColour> CardColours { get; set; }
    public int ManaCost { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public bool IsFoil { get; set; }

    public override string ToString()
    {
        string cardBorder = "-----------------------";
        string nameLine = $"| {Name.ToUpper()}";
        string typeLine = $"| Type: {Type}";
        string manaCostLine = $"| ManaCost: {ManaCost}";
        string priceLine = $"| Price: {Price}";
        string editionLine = $"| {(IsFoil ? "Foil edition" : "Regular edition")}";

        string card = $"\n+{cardBorder} +\n{nameLine,-24} |\n{typeLine,-24} |\n{manaCostLine,-24} |\n{priceLine,-24} |\n{editionLine,-24} |\n+{cardBorder} +";

        return card;
    }


}