﻿using CasosDeUso.Pedidos.Interfaces.Gateway;
using Entidades.Pedidos;
using InterfaceAdapters.Bases.Gateway;
using NHibernate;

namespace InterfaceAdapters.Pedidos.Gateway
{

    public class PedidoGateway(ISession session) : BaseGateway<Pedido>(session), IPedidoGateway
    {
    }

}
