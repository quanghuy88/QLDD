using System.ComponentModel.DataAnnotations;

namespace RIS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}