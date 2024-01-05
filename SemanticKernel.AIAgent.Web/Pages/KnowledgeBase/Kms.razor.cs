using SemanticKernel.AIAgent.Domain.Repositories;
using SemanticKernel.AIAgent.Web.Data.Application.App.Dto;
using SemanticKernel.AIAgent.Web.Data.Application.Kms.Dto;

namespace SemanticKernel.AIAgent.Web.Pages.KnowledgeBase
{
    public partial class Kms : ProComponentBase
    {
        public bool? visible;
        private string _search;

        [Inject]
        public NavigationManager Nav { get; set; } = default!;
        private string GetEchartKey()
        {
            return MasaBlazor.Application.Left.ToString() + MasaBlazor.Breakpoint.Width;
        }

        private void MasaBlazorOnBreakpointChanged(object? sender, BreakpointChangedEventArgs e)
        {
            OnPropertyChanged();
        }

        private void OnPropertyChanged()
        {
            if (NavHelper.CurrentUri.EndsWith("knowledgebase/kms"))
            {
                InvokeAsync(StateHasChanged);
            }
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged();
        }

        public void Dispose()
        {
            MasaBlazor.BreakpointChanged -= MasaBlazorOnBreakpointChanged;
            MasaBlazor.Application.PropertyChanged -= OnPropertyChanged;
        }

        private void AddKms(KmsDto kmsData)
        {
            Kmss app = new Kmss()
            {
                Id = Guid.NewGuid().ToString(),
                Name = kmsData.Name,
                ChatModel = kmsData.ChatModel,
                EmbeddingModel=kmsData.EmbeddingModel
            };

            _kmss_Repositories.Insert(app);
        }

        private void NavigateToDetail()
        {
            Nav.NavigateTo($"knowledgebase/kmsdetail");
        }
    }
}
