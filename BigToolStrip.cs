using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace multiplayer_paint
{
    class BigToolStrip : ToolStrip
    {
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            this.Height = 65;
        }
    }
}