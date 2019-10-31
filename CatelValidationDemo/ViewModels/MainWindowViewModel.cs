using System;
using System.Collections.Generic;
using Catel.Data;

namespace CatelValidationDemo.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;

    public class MainWindowViewModel : ViewModelBase
    {
        public string TextMessage { get; set; }

        public MainWindowViewModel()
        {
            DeferValidationUntilFirstSaveCall = false;
            
        }

        public override string Title { get { return "Welcome to CatelValidationDemo"; } }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }

        protected override void ValidateFields(List<IFieldValidationResult> validationResults)
        {
            if (string.IsNullOrEmpty(TextMessage))
            {
                validationResults.Add(new FieldValidationResult("TextMessage", ValidationResultType.Error, "Text message cannot be empty"));
            }
            base.ValidateFields(validationResults);
        }
    }
}
