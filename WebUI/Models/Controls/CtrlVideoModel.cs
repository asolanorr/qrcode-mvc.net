using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Controls
{
    public class CtrlVideoModel : CtrlBaseModel
    {
        public string Class { get; set; }
        public CtrlVideoModel()
        {
            ViewName = "";
        }
    }
}