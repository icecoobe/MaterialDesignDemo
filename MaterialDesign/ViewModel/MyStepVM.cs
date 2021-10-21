using MaterialDesignExtensions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesign.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>它不是必须为ViewModel类型的</remarks>
    public class MyStepVM : ViewModel
    {
        private List<IStep> _steps;

        public MyStepVM()
        {
            _steps = new List<IStep>()
                {
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "What is a Stepper?" }, Content = new StepperOneViewModel() },
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "Layout and navigation" }, Content = new StepperTwoViewModel() },
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "Steps", SecondLevelTitle = "Header and content" }, Content = new StepperThreeViewModel() },
                    new Step() { Header = new StepTitleHeader() { FirstLevelTitle = "Validation" }, Content = new StepperFourViewModel() }
                };
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IStep> Steps
        {
            get
            {
                return _steps;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>非必须为 ViewModel 子类，主要是为了双向绑定更新</remarks>
    public class StepperOneViewModel //: ViewModel
    {
        public StepperOneViewModel() { }
    }

    public class StepperTwoViewModel : ViewModel
    {
        public StepperTwoViewModel() { }
    }

    public class StepperThreeViewModel : ViewModel
    {
        public StepperThreeViewModel() { }
    }

    public class StepperFourViewModel : ViewModel
    {
        public StepperFourViewModel() { }
    }
}
