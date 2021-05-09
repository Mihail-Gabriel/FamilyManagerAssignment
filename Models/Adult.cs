using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace Models {
public class Adult {
    public int Id { get; set; }
    public Person Persona { get; set; }
    
    public Job AdultJob { get; set; }
    public override string ToString()
    {
        return Persona.FirstName + " " + Persona.LastName + " " + Persona.HairColor + " " 
               + Persona.EyeColor + " " + Persona.Age + " " + Persona.Height + " " + Persona.Weight +
               " " + Persona.Sex;
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;
        Adult helper = obj as Adult;
        return AdultJob.Equals(helper.AdultJob) && Persona.Age == helper.Persona.Age && Persona.Height == helper.Persona.Height &&
               Persona.Id == helper.Persona.Id
               && Persona.Sex.Equals(helper.Persona.Sex) && Persona.Weight.Equals(helper.Persona.Weight) &&
               Persona.EyeColor.Equals(helper.Persona.EyeColor)
               && Persona.FirstName.Equals(helper.Persona.FirstName) && Persona.HairColor.Equals(helper.Persona.HairColor) &&
               Persona.LastName.Equals(helper.Persona.LastName);
    }
}
}