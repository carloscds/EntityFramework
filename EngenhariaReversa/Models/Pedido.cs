﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            PedidoItem = new HashSet<PedidoItem>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int ClienteId { get; set; }
        public decimal Total { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual ICollection<PedidoItem> PedidoItem { get; set; }
    }
}