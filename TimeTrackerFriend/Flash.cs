using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerFriend
{
    public partial class formFlash : Form
    {
        double opacityRate;
        public formFlash()
        {
            InitializeComponent();
            opacityRate = 1;
            this.Size = new Size(SystemInformation.VirtualScreen.X, SystemInformation.VirtualScreen.Y);
        }

        public void FlashDisapear()
        {
            if (opacityRate > 0)
            {
                opacityRate -= 0.1;
                this.Opacity = opacityRate;
            }
            else
                Close();
        }
        
        #region Instrucciones para TopMost y No Activate

        /// <summary>
        /// Con esta función se evita que la ventana tome el foco y cuando la persona está trabajando en otra aplicación
        /// Por ejemplo Office o OpenOffice o Autocad, no interrumpa su trabajo
        /// </summary>
        protected override bool ShowWithoutActivation => true;

        /// <summary>
        /// Usando la variable y la función siguiente, se pone la ventana por encima de cualquier otra ventana del sistema operativo (Escritorio)
        /// No se usa 'TopMost' de C#, porque la función de mas arriba 'ShowWithoutActivation' NO funciona con 'TopMost'
        /// </summary>
        private const int wsExTopmost = 0x00000008;

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;

                createParams.ExStyle |= wsExTopmost;

                return createParams;
            }
        }

        #endregion
    }
}
