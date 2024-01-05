namespace SemanticKernel.AIAgent.Web.Pages.Setting
{
    public partial class Detail : ProComponentBase
    {
       

        private void MasaBlazorOnBreakpointChanged(object? sender, BreakpointChangedEventArgs e)
        {
            OnPropertyChanged();
        }

        private void OnPropertyChanged()
        {
            if (NavHelper.CurrentUri.EndsWith("setting/detail"))
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
    }
}
