﻿/*Amatrix Data Center
    Copyright (C) 2013  Oscar Arjun Singh Tark, Benjamin Jack Johnson

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class Gadg_maps : UserControl
    {
        public Gadg_maps()
        {
            InitializeComponent();
            this.Disposed += new EventHandler(Gadg_maps_Disposed);
        }

        void Gadg_maps_Disposed(object sender, EventArgs e)
        {
            this.Disposed -= Gadg_maps_Disposed;
            this.Leave -= Gadg_maps_Leave;
        }

        private void Gadg_maps_Leave(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
