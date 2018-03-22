using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skillset_PL.ViewModels
{
    public class SkillViewModel
    {
        [Required]
        [Display(Name = "Skill Name")]
        public string SkillName
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Skill Description")]
        public string SkillDescription
        {
            get;
            set;
        }
    }
}