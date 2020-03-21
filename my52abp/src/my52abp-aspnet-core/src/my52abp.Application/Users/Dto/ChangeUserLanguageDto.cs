using System.ComponentModel.DataAnnotations;

namespace my52abp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}