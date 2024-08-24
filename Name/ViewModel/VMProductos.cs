using Name.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Name.ViewModel
{
    class VMProductos
    {
        public ObservableCollection<MProductos> MisProductos { get; set; }
        public VMProductos() { 
            MisProductos = new ObservableCollection<MProductos>
            {
                new MProductos{ Nombre="Coca Lata", Foto ="https://img.freepik.com/fotos-premium/lata-roja-coca-cola-sienta-superficie-blanca_979014-7782.jpg"},
                new MProductos{ Nombre="Inca Lata", Foto ="https://i.pinimg.com/originals/f4/5b/d2/f45bd2f4825688f98d4a1d9214b65aec.png"},
                new MProductos{ Nombre="Pepsi lata", Foto =""},
                new MProductos{ Nombre="Prodcuto 1", Foto =""},
                new MProductos{ Nombre="Prodcuto 1", Foto =""},
                new MProductos{ Nombre="Prodcuto 1", Foto =""},
                new MProductos{ Nombre="Prodcuto 1", Foto =""},
                new MProductos{ Nombre="Prodcuto 1", Foto =""},
                new MProductos{ Nombre="Prodcuto 1", Foto =""},
                new MProductos{ Nombre="Prodcuto 1", Foto =""}
            };
        }
    }
}
