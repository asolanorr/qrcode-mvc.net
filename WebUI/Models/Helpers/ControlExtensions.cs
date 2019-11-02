using System.Web;
using System.Web.Mvc;
using WebUI.Models.Controls;

namespace WebUI.Models.Helpers
{
    public static class ControlExtensions
    {
        public static HtmlString CtrlInput(this HtmlHelper html, string id, string type, string label, string placeHolder = "")
        {
            var ctrl = new CtrlInputModel
            {
                Id = id,
                Type = type,
                Label = label,
                PlaceHolder = placeHolder
            };

            return new HtmlString(ctrl.GetHtml());
        }
        public static HtmlString CtrlQRBox(this HtmlHelper html, string id)
        {
            var ctrl = new CtrlQRBoxModel
            {
                Id = id
            };

            return new HtmlString(ctrl.GetHtml());
        }

        public static HtmlString CtrlButton(this HtmlHelper html, string viewName, string id, string label, string onClickFunction = "", string buttonType = "primary")
        {
            var ctrl = new CtrlButtonModel
            {
                ViewName = viewName,
                Id = id,
                Label = label,
                FunctionName = onClickFunction,
                ButtonType = buttonType
            };

            return new HtmlString(ctrl.GetHtml());
        }

        public static HtmlString CtrlVideo(this HtmlHelper html, string id, string style)
        {
            var ctrl = new CtrlVideoModel
            {
                Id = id,
                Class = style
            };

            return new HtmlString(ctrl.GetHtml());
        }
    }
}