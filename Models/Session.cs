using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Confrence_App.Models
{
    public partial class Session : ObservableObject
    {
        //Static
        public int Id { get; set; }

        public string Title { get; set; }

        public string Room { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string StartDisplay => $"{Start:t}";

        public string DayDisplay => $"{Start:MMM} {Start:d}";

        public Speaker Speaker { get; set; } = new Speaker
        {
            Name = "Mary Olasehinde",
            Company = "Microsoft",
            Description = "Mary Olasehinde is a Principal Lead Program Manager on Microsoft. She Is Hardworking, Smart, Dilligent, Strong and good at her work. She Loves Coffee",
            Title = "Principal Lead Program Manager"
        };

        //Dynamic

        [ObservableProperty]
        bool inAgenda;
    }
}
