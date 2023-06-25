using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBlazor2.Shared.Entities
{
    public class CreateItem
    {
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string Text { get; set; } = string.Empty;
    }
}