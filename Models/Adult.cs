using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Humanizer.DateTimeHumanizeStrategy;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace Models {
public class Adult : Person {
    public Job JobTitle { get; set; }
    public override string ToString()
    {
        return FirstName + " " + LastName + " " + HairColor + " " + EyeColor + " " + Age + " " + Height + " " + Weight +
               " " + Sex;
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;
        Adult helper = obj as Adult;
        return JobTitle.Equals(helper.JobTitle) && Age == helper.Age && Height == helper.Height &&
               Id == helper.Id
               && Sex.Equals(helper.Sex) && Weight.Equals(helper.Weight) &&
               EyeColor.Equals(helper.EyeColor)
               && FirstName.Equals(helper.FirstName) && HairColor.Equals(helper.HairColor) &&
               LastName.Equals(helper.LastName);
    }
}
}