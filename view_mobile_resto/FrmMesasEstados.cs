using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using view_mobile_resto.Clases;
using view_mobile_resto.Controller;

namespace view_mobile_resto
{
    public partial class FrmMesasEstados : Form
    {
        private List<Mesa> listMesas = TrabajarMesas.traer_mesas();

        public FrmMesasEstados()
        {
            InitializeComponent();
        }        

        private void estado_mesas()
        {
            foreach (Mesa mesa in listMesas) {
                switch (mesa.Id)                {
                    case 1:
                        esignarColor(btnMesa1, mesa.Estado); break;
                    case 2:
                        esignarColor(btnMesa2, mesa.Estado); break;
                    case 3:
                        esignarColor(btnMesa3, mesa.Estado); break;
                    case 4:
                        esignarColor(btnMesa4, mesa.Estado); break;
                    case 5:
                        esignarColor(btnMesa5, mesa.Estado); break;
                    case 6:
                        esignarColor(btnMesa6, mesa.Estado); break;
                    case 7:
                        esignarColor(btnMesa7, mesa.Estado); break;
                    case 8:
                        esignarColor(btnMesa8, mesa.Estado); break;
                    case 9:
                        esignarColor(btnMesa9, mesa.Estado); break;
                }
            }
        }

        private void esignarColor(Button bot, int est)
        {
            switch (est)
            {
                case 1:
                    bot.BackColor = Color.Red;
                    break;
                case 2:
                    bot.BackColor = Color.Blue; 
                    break;
                case 3:
                    bot.BackColor = Color.Green; 
                    break;
            }
        }

        private void hacer_pedido(object sender, EventArgs e)
        {
            Button btnMesa = (Button)sender;
            switch (btnMesa.Name) {
                case "btnMesa1":
                    seleccionar_mesa(1);
                    break;
                case "btnMesa2":
                    seleccionar_mesa(2);
                    break;
                case "btnMesa3":
                    seleccionar_mesa(3);
                    break;
                case "btnMesa4":
                    seleccionar_mesa(4);
                    break;
                case "btnMesa5":
                    seleccionar_mesa(5);
                    break;
                case "btnMesa6":
                    seleccionar_mesa(6);
                    break;
                case "btnMesa7":
                    seleccionar_mesa(7);
                    break;
                case "btnMesa8":
                    seleccionar_mesa(8);
                    break;
                case "btnMesa9":
                    seleccionar_mesa(9);
                    break;
            }
        }

        private void seleccionar_mesa(int id_mesa)
        {
            if (listMesas[id_mesa - 1].Estado == 3)
            {
                FrmPedido ped = new FrmPedido(id_mesa);
                ped.Show();
            }
            else
            {
                Pedido pedido = TrabajarPedido.traer_pedido(id_mesa);
                FrmPedido ped = new FrmPedido(pedido);
                ped.Show();
            }
        }

        private void FrmMesasEstados_GotFocus(object sender, EventArgs e)
        {
            listMesas = TrabajarMesas.traer_mesas();
            estado_mesas();
        }



    }
}