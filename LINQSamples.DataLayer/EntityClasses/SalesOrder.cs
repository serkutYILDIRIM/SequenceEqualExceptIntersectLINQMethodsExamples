using System.Text;

namespace LINQSamples
{
  public partial class SalesOrder
  {
    public int SalesOrderID { get; set; }
    public short OrderQty { get; set; }
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal LineTotal { get; set; }
  }
}
