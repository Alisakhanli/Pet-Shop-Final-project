using Miau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miau.ViewModels
{
    public class HomeIndexViewModel
    {
        public Slider Slider { get; set; }
        public List<SliderImage> SliderImages { get; set; }
        public Service Services { get; set; }
        public ServiceBox ServiceBoxes { get; set; }
        public ServiceBox2 ServiceBoxes2 { get; set; }
        public ServiceBox3 ServiceBoxes3 { get; set; }
        public About Abouts { get; set; }
        public List<AboutImage> AboutImages { get; set; }
        public Adopt Adopts { get; set; }
        public Comment Comments { get; set; }
        public OurTeam OurTeams { get; set; }
        public OurTeamImage1 OurTeamImage1 { get; set; }
        public OurTeamImage2 OurTeamImage2 { get; set; }
        public OurTeamImage3 OurTeamImage3 { get; set; }
        public Pat Pats { get; set; }
    }
}
