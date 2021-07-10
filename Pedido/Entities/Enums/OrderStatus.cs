namespace Pedido.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0, // pedindo pagamentos
        Processing = 1,     //processando
        Shipped = 2,        // enviado
        Delivered = 3       // entregue
    }
}
