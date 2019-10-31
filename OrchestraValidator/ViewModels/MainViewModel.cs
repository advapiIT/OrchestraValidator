using Catel.Data;

namespace OrchestraValidator.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;

    public class MainViewModel : ViewModelBase
    {
        public string TextMessage { get; set; }
        public MainViewModel()
        {
            DeferValidationUntilFirstSaveCall = false;
        }

        public override string Title { get { return "Welcome to OrchestraValidator"; } }

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

        protected override void OnValidatedFields(IValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(TextMessage))
            {
                validationContext.Add(new FieldValidationResult("TextMessage", ValidationResultType.Error, "Text message cannot be empty"));
            }
            base.OnValidatedFields(validationContext);
        }
    }
}