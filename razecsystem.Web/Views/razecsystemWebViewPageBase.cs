using Abp.Web.Mvc.Views;

namespace razecsystem.Web.Views
{
    public abstract class razecsystemWebViewPageBase : razecsystemWebViewPageBase<dynamic>
    {

    }

    public abstract class razecsystemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected razecsystemWebViewPageBase()
        {
            LocalizationSourceName = razecsystemConsts.LocalizationSourceName;
        }
    }
}