﻿using System.Text.Json.Serialization;
using Mental_Hospital.Models.Light;
using Mental_Hospital.Models.Severe;

namespace Mental_Hospital.Models;



[JsonDerivedType(typeof(LightAnxiety), typeDiscriminator: nameof(LightAnxiety))]
[JsonDerivedType(typeof(SevereAnxiety), typeDiscriminator: nameof(SevereAnxiety))]
public abstract class Diagnosis : IEntity
{
    [JsonConstructor]
    protected Diagnosis()
    {
    }

    public Guid IdDisorder { get; set; } 
    public virtual string NameOfDisorder { get; set; }
    public virtual string Description { get; set; }
    public DateTime DateOfDiagnosis { get; set; }
    public DateTime? DateOfHealing { get; set; }
    public Guid? IdPatient{ get; set;  }
    [JsonIgnore]

    public virtual Patient Patient { get; set; }
}