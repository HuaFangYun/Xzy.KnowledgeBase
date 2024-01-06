using SemanticKernel.AIAgent.Domain.Repositories;
using SemanticKernel.AIAgent.Web.Shared;
using System.Data;
using System.Numerics;

namespace SemanticKernel.AIAgent.Web.Pages.KnowledgeBase.ViewModel
{
    public class KmsPage
    {
        public List<KmsDetails> KmsDatas { get; set; }

        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public int PageCount => (int)Math.Ceiling(CurrentCount / (double)PageSize);

        public int CurrentCount => GetFilterDatas().Count();
        public KmsPage(List<KmsDetails> datas)
        {
            KmsDatas = new List<KmsDetails>();
            KmsDatas.AddRange(datas);
        }


        private IEnumerable<KmsDetails> GetFilterDatas()
        {
            IEnumerable<KmsDetails> datas = KmsDatas;

         
            if (datas.Count() < (PageIndex - 1) * PageSize) PageIndex = 1;

            return datas;
        }
        public List<KmsDetails> GetPageDatas()
        {
            return GetFilterDatas().Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }
    }
}
