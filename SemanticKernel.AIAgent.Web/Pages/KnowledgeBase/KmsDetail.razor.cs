namespace SemanticKernel.AIAgent.Web.Pages.KnowledgeBase
{
    public partial class KmsDetail
    {
        private string? _inputText;
        private string? _filterText;
        private bool? _visible;

        [Parameter]
        public string? Id { get; set; }

        [Parameter]
        public string? FilterText
        {
            get { return _filterText; }
            set
            {
                _filterText = value;
            }
        }

        [Parameter]
        public bool? Value { get; set; }

        [Parameter]
        public EventCallback<bool?> ValueChanged { get; set; }

        [Parameter]
        public Object? SelectItem { get; set; }

        private void InputTextChanged(string? text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                // _thisList = _dataList.Where(item => item.Title.Contains(text)).ToList();
            }
            else
            {
                // _thisList = _dataList;
            }
        }

        public string? InputText
        {
            get { return _inputText; }
            set
            {
                _inputText = value;
                InputTextChanged(_inputText);
            }
        }
    }
}
