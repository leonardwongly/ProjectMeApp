using System;

using Xamarin.Forms;

namespace ltl96
{
    public class MainPageCS : TabbedPage
    {
        public MainPageCS()
        {
			var homePage = new NavigationPage(new HomePage());
			homePage.Icon = "home.png";

			var educationPage = new NavigationPage(new EducationPage());
			educationPage.Icon = "education.png";

			var jobPage = new NavigationPage(new JobPage());
			jobPage.Icon = "job.png";

			var skillsPage = new NavigationPage(new SkillsPage());
			skillsPage.Icon = "skills.png";

			var morePage = new NavigationPage(new MorePage());
			morePage.Icon = "more.png";

			Children.Add(homePage);
			Children.Add(educationPage);
			Children.Add(jobPage);
			Children.Add(skillsPage);
			Children.Add(morePage);
        }
    }
}

