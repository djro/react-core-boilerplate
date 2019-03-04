using System.ComponentModel.DataAnnotations;

namespace react-core-boilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}