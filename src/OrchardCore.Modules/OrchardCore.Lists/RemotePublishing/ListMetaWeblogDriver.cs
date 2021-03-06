using System.Threading.Tasks;
using OrchardCore.Modules;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Lists.Models;

namespace OrchardCore.Lists.RemotePublishing
{
    [RequireFeatures("OrchardCore.RemotePublishing")]
    public class ListMetaWeblogDriver : ContentPartDisplayDriver<ListPart>
    {
        public override IDisplayResult Display(ListPart listPart, BuildPartDisplayContext context)
        {
            return Shape("ListPart_RemotePublishing", shape =>
            {
                shape.ContentItem = listPart.ContentItem;
                return Task.CompletedTask;
            }).Location("Content");
        }
    }
}