using MaterialDesignExtensions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesign.ViewModel
{
    public class MyStepVM : ViewModel
    {
        private List<IStep> _steps;

        public MyStepVM()
        {
            _steps = new List<IStep>()
                {
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "What is a Stepper?" }, Content = new StepperTutorialOneViewModel() },
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "Layout and navigation" }, Content = new StepperTutorialTwoViewModel() },
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "Steps", SecondLevelTitle = "Header and content" }, Content = new StepperTutorialThreeViewModel() },
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "Validation" }, Content = new StepperTutorialFourViewModel() }
                };
        }

        public IEnumerable<IStep> Steps
        {
            get
            {
                return _steps;
            }
        }
    }

    public class StepperOneViewModel
    {
        public StepperOneViewModel() { }
    }

    public class StepperTwoViewModel
    {
        public StepperTwoViewModel() { }
    }

    public class StepperThreeViewModel
    {
        public StepperThreeViewModel() { }
    }

    public class StepperFourViewModel
    {
        public StepperFourViewModel() { }
    }
}
