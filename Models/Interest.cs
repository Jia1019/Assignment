using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace Models {
public class Interest {
    [Key]
    [ValidInterestType]
    public string Type { get; set; }

    public List<string> validTypes { get; set; }

    public Interest()
        {
            validTypes = new[]
            {
                "Soccer", "Drawing", "Kite Flying", "Roller Blades", "Board Games", "Ballet", "Hockey",
                "Gaming", "Lego", "Scout", "Gymnastics", "Harry Potter", "Frozen"
            }.ToList();
        }
    
}

    


    public class ValidInterestType : ValidationAttribute
    {
        private List<string> valid = new[]
                    {
                        "Soccer", "Drawing", "Kite Flying", "Roller Blades", "Board Games", "Ballet", "Hockey",
                        "Gaming", "Lego", "Scout", "Gymnastics", "Harry Potter", "Frozen"
                    }.ToList();
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (valid != null && valid.ToString().ToLower().Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Valid interest types are: Soccer, Drawing, Kite Flying, Roller Blades," +
                                        "Board Games, Ballet, Hockey, Gaming, Lego, Scout, Gymnastics, Harry Potter, Frozen");
        }
    }

}
