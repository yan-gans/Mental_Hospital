﻿using System.Text.Json.Serialization;

namespace Mental_Hospital.Models;

public class Equipment : IEntity
{
    private Room? _room;

    public Guid IdEquipment { get; set; } 
    public string Name { get; set; }
    public DateTime ExpirationDate { get; set; }
    public Guid? IdRoom{ get; set;  }

    [JsonIgnore]
    public virtual Room? Room
    {
        get => _room;
        set
        {
            IdRoom = value?.IdRoom;
            _room = value;
        }
    }
}