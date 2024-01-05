using SemanticKernel.AIAgent.Domain.Map;
using SemanticKernel.AIAgent.Domain.Repositories;
using SemanticKernel.AIAgent.Web.Data.Application.App.Dto;

namespace SemanticKernel.AIAgent.Web.Pages.App
{
    public partial class AppList() : ProComponentBase
    {
        public bool? visible;
        private string _search;

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
            if (NavHelper.CurrentUri.EndsWith("app/applist"))
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


        private void AddApp(AppDto appData)
        {
            Apps app=new Apps() { 
            Id=Guid.NewGuid().ToString(),
            Name=appData.Name,
            Describe=appData.Describe
            };

            _apps_Repositories.Insert(app);
        }
    }
}
