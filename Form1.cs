using Arboles;
using System;
using System.Windows.Forms;

namespace ArbolesG2_2024_1
{
    public partial class Form1 : Form
    {
        private Arbol arbol; //Por default es nula
        public Form1()
        {
            InitializeComponent();
            arbol = new Arbol(ptbArbol);
        }

        private void txtbNodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int dato = int.Parse(txtbNodo.Text);
                arbol.inserta_nodo(arbol.Raiz, null, dato, 0);
                txtbNodo.Clear();
            }
            if (e.KeyChar == (char)Keys.P)
            {
                arbol.preorden(arbol.Raiz);
            }
            else if (e.KeyChar == (char)Keys.O)
            {
                arbol.posorden(arbol.Raiz);
            }
            else if (e.KeyChar == (char)Keys.I)
            {
                arbol.inorden(arbol.Raiz);
            }
        }
    }
}
