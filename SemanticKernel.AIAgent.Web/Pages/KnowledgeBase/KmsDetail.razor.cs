using SemanticKernel.AIAgent.Domain.Repositories;
using SemanticKernel.AIAgent.Web.Pages.KnowledgeBase.ViewModel;

namespace SemanticKernel.AIAgent.Web.Pages.KnowledgeBase
{
    public partial class KmsDetail
    {
        private string? _inputText;
        private bool? _visible;
        public KmsPage _kmsPage = new KmsPage(new List<KmsDetails>());
       
        [Parameter]
        public string? Id { get; set; }

        [Parameter]
        public bool? Value { get; set; }

        [Parameter]
        public EventCallback<bool?> ValueChanged { get; set; }

        [Parameter]
        public Object? SelectItem { get; set; }

        private readonly List<DataTableHeader<KmsDetails>> _headers = new()
        {
            new() { Text = "Id", Value = nameof(KmsDetails.Id)  },
            new() { Text = "文件名", Value = nameof(KmsDetails.FileName) },
            new() { Text = "数据数量", Value = nameof(KmsDetails.DataCount) },
            new() { Text = "状态", Value = nameof(KmsDetails.Status) },
            new() { Text = "创建时间", Value = nameof(KmsDetails.CreateTime) },
        };

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
