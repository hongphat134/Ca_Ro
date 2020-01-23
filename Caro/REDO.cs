using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    class REDO
    {
        private Button btn;

        public Button Btn
        {
            get { return btn; }
            set { btn = value; }
        }
        private int curr;

        public int Curr
        {
            get { return curr; }
            set { curr = value; }
        }

        public REDO(Button but,int diem)
        {
            btn = but;
            curr = diem;
        }
    }
}
