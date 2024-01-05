namespace SemanticKernel.AIAgent.Web.Pages.Chat
{
    public partial class Chat : ProComponentBase
    {
       

        private void MasaBlazorOnBreakpointChanged(object? sender, BreakpointChangedEventArgs e)
        {
            OnPropertyChanged();
        }

        private void OnPropertyChanged()
        {
            if (NavHelper.CurrentUri.EndsWith("chat/chat"))
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
